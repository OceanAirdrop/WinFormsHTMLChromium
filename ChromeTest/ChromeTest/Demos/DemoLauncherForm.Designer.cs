namespace ChromeTest.Demos
{
    partial class DemoLauncherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBootstrapDemo1 = new System.Windows.Forms.Button();
            this.buttonBootstrapDemo2 = new System.Windows.Forms.Button();
            this.buttonAmChartsDemo = new System.Windows.Forms.Button();
            this.buttonWebGLDemo = new System.Windows.Forms.Button();
            this.buttonCanvasParticleDemo = new System.Windows.Forms.Button();
            this.buttonJQWidgetsDemo = new System.Windows.Forms.Button();
            this.buttonCanvasBubblesDemo = new System.Windows.Forms.Button();
            this.buttonBootStrapDemo3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBootstrapDemo1
            // 
            this.buttonBootstrapDemo1.Location = new System.Drawing.Point(39, 18);
            this.buttonBootstrapDemo1.Name = "buttonBootstrapDemo1";
            this.buttonBootstrapDemo1.Size = new System.Drawing.Size(180, 51);
            this.buttonBootstrapDemo1.TabIndex = 0;
            this.buttonBootstrapDemo1.Text = "Bootstrap Landing Page Demo 1";
            this.buttonBootstrapDemo1.UseVisualStyleBackColor = true;
            this.buttonBootstrapDemo1.Click += new System.EventHandler(this.buttonBootstrapDemo1_Click);
            // 
            // buttonBootstrapDemo2
            // 
            this.buttonBootstrapDemo2.Location = new System.Drawing.Point(39, 91);
            this.buttonBootstrapDemo2.Name = "buttonBootstrapDemo2";
            this.buttonBootstrapDemo2.Size = new System.Drawing.Size(180, 46);
            this.buttonBootstrapDemo2.TabIndex = 1;
            this.buttonBootstrapDemo2.Text = "Bootstrap Form Entry Demo 2";
            this.buttonBootstrapDemo2.UseVisualStyleBackColor = true;
            this.buttonBootstrapDemo2.Click += new System.EventHandler(this.buttonBootstrapDemo2_Click);
            // 
            // buttonAmChartsDemo
            // 
            this.buttonAmChartsDemo.Location = new System.Drawing.Point(458, 88);
            this.buttonAmChartsDemo.Name = "buttonAmChartsDemo";
            this.buttonAmChartsDemo.Size = new System.Drawing.Size(180, 46);
            this.buttonAmChartsDemo.TabIndex = 3;
            this.buttonAmChartsDemo.Text = "AM Charts Demo";
            this.buttonAmChartsDemo.UseVisualStyleBackColor = true;
            this.buttonAmChartsDemo.Click += new System.EventHandler(this.buttonAmChartsDemo_Click);
            // 
            // buttonWebGLDemo
            // 
            this.buttonWebGLDemo.Location = new System.Drawing.Point(250, 16);
            this.buttonWebGLDemo.Name = "buttonWebGLDemo";
            this.buttonWebGLDemo.Size = new System.Drawing.Size(180, 46);
            this.buttonWebGLDemo.TabIndex = 5;
            this.buttonWebGLDemo.Text = "WebGL Demo";
            this.buttonWebGLDemo.UseVisualStyleBackColor = true;
            this.buttonWebGLDemo.Click += new System.EventHandler(this.buttonWebGLDemo_Click);
            // 
            // buttonCanvasParticleDemo
            // 
            this.buttonCanvasParticleDemo.Location = new System.Drawing.Point(250, 88);
            this.buttonCanvasParticleDemo.Name = "buttonCanvasParticleDemo";
            this.buttonCanvasParticleDemo.Size = new System.Drawing.Size(180, 46);
            this.buttonCanvasParticleDemo.TabIndex = 6;
            this.buttonCanvasParticleDemo.Text = "Canvas Particle Demo";
            this.buttonCanvasParticleDemo.UseVisualStyleBackColor = true;
            this.buttonCanvasParticleDemo.Click += new System.EventHandler(this.buttonCanvasParticleDemo_Click);
            // 
            // buttonJQWidgetsDemo
            // 
            this.buttonJQWidgetsDemo.Location = new System.Drawing.Point(250, 163);
            this.buttonJQWidgetsDemo.Name = "buttonJQWidgetsDemo";
            this.buttonJQWidgetsDemo.Size = new System.Drawing.Size(180, 46);
            this.buttonJQWidgetsDemo.TabIndex = 7;
            this.buttonJQWidgetsDemo.Text = "JQWidgets Demo";
            this.buttonJQWidgetsDemo.UseVisualStyleBackColor = true;
            // 
            // buttonCanvasBubblesDemo
            // 
            this.buttonCanvasBubblesDemo.Location = new System.Drawing.Point(458, 16);
            this.buttonCanvasBubblesDemo.Name = "buttonCanvasBubblesDemo";
            this.buttonCanvasBubblesDemo.Size = new System.Drawing.Size(180, 46);
            this.buttonCanvasBubblesDemo.TabIndex = 8;
            this.buttonCanvasBubblesDemo.Text = "Canvas Bubbles Demo";
            this.buttonCanvasBubblesDemo.UseVisualStyleBackColor = true;
            this.buttonCanvasBubblesDemo.Click += new System.EventHandler(this.buttonCanvasBubblesDemo_Click);
            // 
            // buttonBootStrapDemo3
            // 
            this.buttonBootStrapDemo3.Location = new System.Drawing.Point(39, 163);
            this.buttonBootStrapDemo3.Name = "buttonBootStrapDemo3";
            this.buttonBootStrapDemo3.Size = new System.Drawing.Size(180, 46);
            this.buttonBootStrapDemo3.TabIndex = 9;
            this.buttonBootStrapDemo3.Text = "Bootstrap Form Entry Demo 3";
            this.buttonBootStrapDemo3.UseVisualStyleBackColor = true;
            this.buttonBootStrapDemo3.Click += new System.EventHandler(this.buttonBootStrapDemo3_Click);
            // 
            // DemoLauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 243);
            this.Controls.Add(this.buttonBootStrapDemo3);
            this.Controls.Add(this.buttonCanvasBubblesDemo);
            this.Controls.Add(this.buttonJQWidgetsDemo);
            this.Controls.Add(this.buttonCanvasParticleDemo);
            this.Controls.Add(this.buttonWebGLDemo);
            this.Controls.Add(this.buttonAmChartsDemo);
            this.Controls.Add(this.buttonBootstrapDemo2);
            this.Controls.Add(this.buttonBootstrapDemo1);
            this.Name = "DemoLauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DemoLauncherForm";
            this.Load += new System.EventHandler(this.DemoLauncherForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBootstrapDemo1;
        private System.Windows.Forms.Button buttonBootstrapDemo2;
        private System.Windows.Forms.Button buttonAmChartsDemo;
        private System.Windows.Forms.Button buttonWebGLDemo;
        private System.Windows.Forms.Button buttonCanvasParticleDemo;
        private System.Windows.Forms.Button buttonJQWidgetsDemo;
        private System.Windows.Forms.Button buttonCanvasBubblesDemo;
        private System.Windows.Forms.Button buttonBootStrapDemo3;
    }
}