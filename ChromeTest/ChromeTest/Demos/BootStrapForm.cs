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
    public partial class BootStrapForm : Form
    {
        ChromiumWebBrowser m_chromeBrowser = null;

        public BootStrapForm()
        {
            InitializeComponent();
        }

        private void BootStrapForm_Load(object sender, EventArgs e)
        {
           // Cef.Initialize();

            string page = string.Format("{0}HTMLResources/html/BootstrapExample.html", GetAppLocation());
            m_chromeBrowser = new ChromiumWebBrowser(page);

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

        private void BootStrapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cef.Shutdown();
        }

        public static string GetAppLocation()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
