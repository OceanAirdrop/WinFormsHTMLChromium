using CefSharp;
using CefSharp.WinForms;
using ChromeTest.Demos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChromeTest
{
    public partial class MainForm : Form
    {
        ChromiumWebBrowser m_chromeBrowser = null;


        public static string GetAppLocation()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cef.Initialize();
            m_chromeBrowser = new ChromiumWebBrowser("http://www.maps.google.com");

            panel1.Controls.Add(m_chromeBrowser);

            ChromeDevToolsSystemMenu.CreateSysMenu(this);
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Test if the About item was selected from the system menu
            if ((m.Msg == ChromeDevToolsSystemMenu.WM_SYSCOMMAND) && ((int)m.WParam == ChromeDevToolsSystemMenu.SYSMENU_CHROME_DEV_TOOLS))
            {
                m_chromeBrowser.ShowDevTools();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void buttonShowDevTools_Click(object sender, EventArgs e)
        {
            m_chromeBrowser.ShowDevTools();
        }

        private void buttonChangeAddress_Click(object sender, EventArgs e)
        {
            ChangeAddressForm form = new ChangeAddressForm();
            if ( form.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                m_chromeBrowser.Load(form.textBoxAddress.Text);
            }
        }

        private void buttonCustomHTML_Click(object sender, EventArgs e)
        {
            m_chromeBrowser.LoadHtml("<html><body>Hello world</body></html>", "http://customrendering/");
        }

        private void buttonLoadLocalHTML_Click(object sender, EventArgs e)
        {
            //string page = string.Format("{0}HTMLResources/html/BasicPage.html", GetAppLocation());
            //string page = string.Format("{0}HTMLResources/html/BootstrapExample.html", GetAppLocation());

            string page = string.Format("{0}HTMLEmbeddedResources/html/BootstrapExample.html", GetAppLocation());

            m_chromeBrowser.Load(page);
        }



        private void buttonLoadEmbeddedHTML_Click(object sender, EventArgs e)
        {
            //string resource = "";
            //if (EmbeddedResourceUtils.GetResource("BootstrapExample.html", out resource) == true)
            //{
            //    m_chromeBrowser.LoadHtml(resource, "http://customrendering/");
            //}
        }

        JavaScriptInteractionObj m_jsInteractionObj = null;

        private void buttonRegisterCSharpObject_Click(object sender, EventArgs e)
        {
            m_jsInteractionObj = new JavaScriptInteractionObj();
            m_jsInteractionObj.SetChromeBrowser(m_chromeBrowser);

            // Register the JavaScriptInteractionObj class with JS
            m_chromeBrowser.RegisterJsObject("winformObj", m_jsInteractionObj);

            string page = string.Format("{0}HTMLResources/html/WinformInteractionExample.html", GetAppLocation());
            m_chromeBrowser.Load(page);
        }

        private void buttonExecJavaScriptFromWinforms_Click(object sender, EventArgs e)
        {
            m_chromeBrowser.LoadHtml("<html><body>Hello world</body></html>", "http://customrendering/");

            var script = "document.body.style.backgroundColor = 'red';";

            m_chromeBrowser.ExecuteScriptAsync(script);
        }

        private void buttonAmCharts_Click(object sender, EventArgs e)
        {
           // m_chromeBrowser.Load("http://www.amcharts.com/demos/date-based-data/");

            string page = string.Format("{0}HTMLResources/html/amChartExample.html", GetAppLocation());
            m_chromeBrowser.Load(page);
        }

        private void buttonBootStrapFormDemo_Click(object sender, EventArgs e)
        {
            BootStrapForm form = new BootStrapForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
        }

        private void buttonHTMLDemos_Click(object sender, EventArgs e)
        {
            DemoLauncherForm form = new DemoLauncherForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
        }

        private void buttonExecCsharpFromJS_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturnDataFromJavaScript_Click(object sender, EventArgs e)
        {
            m_chromeBrowser.LoadHtml("<html><body>Hello world</body></html>", "http://customrendering/");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("function tempFunction() {");
            sb.AppendLine("     var w = window.innerWidth;");
            sb.AppendLine("     var h = window.innerHeight;");
            sb.AppendLine("");
            sb.AppendLine("     return w*h;");
            sb.AppendLine("}");
            sb.AppendLine("tempFunction();");

            var task = m_chromeBrowser.EvaluateScriptAsync(sb.ToString());

            task.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;

                    if ( response.Success == true )
                    {
                        MessageBox.Show( response.Result.ToString() );
                    }
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void buttonReturnDataFromJavaScript2_Click(object sender, EventArgs e)
        {
            // Step 01: create a simple html page (include jquery so we have access to json object
            StringBuilder htmlPage = new StringBuilder();
            htmlPage.AppendLine("<html>");
            htmlPage.AppendLine("<head>");
            htmlPage.AppendLine("<script type=\"text/javascript\" src=\"http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js\"> </script>");
            htmlPage.AppendLine("</head>");
            htmlPage.AppendLine("<body>Hello world 2</body>");
            htmlPage.AppendLine("</html>");

            // Step 02: Load the Page
            m_chromeBrowser.LoadHtml(htmlPage.ToString(), "http://customrendering/");

            // Step 03: Execute some ad-hoc JS that returns an object back to C#
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("function tempFunction() {");
            sb.AppendLine("     // create a JS object");
            sb.AppendLine("     var person = {firstName:'John', lastName:'Maclaine', age:23, eyeColor:'blue'};");
            sb.AppendLine("");
            sb.AppendLine("     // Important: convert object to string before returning to C#");
            sb.AppendLine("     return JSON.stringify(person);");
            sb.AppendLine("}");
            sb.AppendLine("tempFunction();");

            var task = m_chromeBrowser.EvaluateScriptAsync(sb.ToString());

            task.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    // Step 04: Recieve value from JS
                    var response = t.Result;

                    if (response.Success == true)
                    {
                        // Use JSON.net to convert to object;
                        MessageBox.Show(response.Result.ToString());
                    }
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
