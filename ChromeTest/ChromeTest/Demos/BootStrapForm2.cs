using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChromeTest.Demos
{
    public partial class BootStrapForm2 : Form
    {
        ChromiumWebBrowser m_chromeBrowser = null;

        SomeClass m_javascriptSvc = null;

        public BootStrapForm2()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public static string GetAppLocation()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        private void BootStrapForm2_Load(object sender, EventArgs e)
        {
            string page = string.Format("{0}HTMLResources/html/BootstrapFormExample.html", GetAppLocation());
            m_chromeBrowser = new ChromiumWebBrowser(page);
            m_javascriptSvc = new SomeClass(m_chromeBrowser);


            // Register the JavaScriptInteractionObj class with JS
            m_chromeBrowser.RegisterJsObject("winformObj", m_javascriptSvc);

            Controls.Add(m_chromeBrowser);

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

        private void BootStrapForm2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void BootStrapForm2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                m_chromeBrowser.ShowDevTools();
            }
        }

        private void BootStrapForm2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }

    public class SomeClass
    {
        public Person m_theMan = null;

        [JavascriptIgnore]
        public ChromiumWebBrowser m_chromeBrowser { get; set; }

        public SomeClass(ChromiumWebBrowser webBrwsr )
        {
            m_chromeBrowser = webBrwsr;
        }

        public string SomeFunction()
        {
            return "yippieee";
        }

        public void ButtonPressed(string buttonName)
        {
            //MessageBox.Show(string.Format("Message box from C# winforms. Msg: {0}", buttonName));

           // var script = "document.body.style.backgroundColor = 'red';";
            //var script = "$('#inputEmail').val('a@a.com');";

            // var script = "var x = 1234";
            var script = "msgBoxFromJavaScript();";

            m_chromeBrowser.ExecuteScriptAsync(script);

        }
    }
}
