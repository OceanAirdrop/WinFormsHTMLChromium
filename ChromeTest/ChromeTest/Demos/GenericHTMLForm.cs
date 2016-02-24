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
    public partial class GenericHTMLForm : Form
    {
        ChromiumWebBrowser m_chromeBrowser = null;

        string m_htmlToDisplay = "";

        public GenericHTMLForm(string formTitle, string htmlToDisplay)
        {
            InitializeComponent();

            this.Text = formTitle;

            m_htmlToDisplay = htmlToDisplay;
        }

        public static string GetAppLocation()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        private void GenericHTMLForm_Load(object sender, EventArgs e)
        {
            m_chromeBrowser = new ChromiumWebBrowser(m_htmlToDisplay);

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
    }
}
