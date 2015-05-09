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
    public partial class DemoLauncherForm : Form
    {
        public DemoLauncherForm()
        {
            InitializeComponent();
        }

        public static string GetAppLocation()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        private void buttonBootstrapDemo1_Click(object sender, EventArgs e)
        {
            BootStrapForm form = new BootStrapForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
        }

        private void buttonBootstrapDemo2_Click(object sender, EventArgs e)
        {
            BootStrapForm2 form = new BootStrapForm2();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
        }

        private void DemoLauncherForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonGenericHTMLForm_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCanvasParticleDemo_Click(object sender, EventArgs e)
        {
            string page = string.Format("{0}HTMLResources/html/canvas-particle.html", GetAppLocation());

            GenericHTMLForm form = new GenericHTMLForm("Canvas Particle Example", page);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
        }

        private void buttonCanvasBubblesDemo_Click(object sender, EventArgs e)
        {
            string page = string.Format("{0}HTMLResources/html/canvas-bubbles.html", GetAppLocation());

            GenericHTMLForm form = new GenericHTMLForm("Canvas Bubbles Example", page);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
        }

        private void buttonCSS3Demo_Click(object sender, EventArgs e)
        {
            GenericHTMLForm form = new GenericHTMLForm("CSS3 Demo", "http://daneden.github.io/animate.css/");
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
        }

        private void buttonWebGLDemo_Click(object sender, EventArgs e)
        {
            GenericHTMLForm form = new GenericHTMLForm("WebGL Demo", "http://www.bongiovi.tw/experiments/webgl/blossom/");// "http://myshards.com/");
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
        }

        private void buttonBootStrapDemo3_Click(object sender, EventArgs e)
        {
            string page = string.Format("{0}HTMLResources/html/BootstrapFormExample2.html", GetAppLocation());

            GenericHTMLForm form = new GenericHTMLForm("Bootstrap Form Example", page);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
        }

        private void buttonAmChartsDemo_Click(object sender, EventArgs e)
        {
            string page = string.Format("{0}HTMLResources/html/amChartExample.html", GetAppLocation());

            GenericHTMLForm form = new GenericHTMLForm("AM Chart Example", page);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("user pressed ok");
            }
        }
    }
}
