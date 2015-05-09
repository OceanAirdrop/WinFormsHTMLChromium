namespace ChromeTest
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShowDevTools = new System.Windows.Forms.Button();
            this.buttonChangeAddress = new System.Windows.Forms.Button();
            this.buttonCustomHTML = new System.Windows.Forms.Button();
            this.buttonLoadLocalHTML = new System.Windows.Forms.Button();
            this.buttonRegisterCSharpObject = new System.Windows.Forms.Button();
            this.buttonExecJavaScriptFromWinforms = new System.Windows.Forms.Button();
            this.buttonHTMLDemos = new System.Windows.Forms.Button();
            this.buttonExecCsharpFromJS = new System.Windows.Forms.Button();
            this.buttonReturnDataFromJavaScript = new System.Windows.Forms.Button();
            this.buttonReturnDataFromJavaScript2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 421);
            this.panel1.TabIndex = 0;
            // 
            // buttonShowDevTools
            // 
            this.buttonShowDevTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowDevTools.Location = new System.Drawing.Point(702, 12);
            this.buttonShowDevTools.Name = "buttonShowDevTools";
            this.buttonShowDevTools.Size = new System.Drawing.Size(135, 32);
            this.buttonShowDevTools.TabIndex = 1;
            this.buttonShowDevTools.Text = "Display Dev Tools";
            this.buttonShowDevTools.UseVisualStyleBackColor = true;
            this.buttonShowDevTools.Click += new System.EventHandler(this.buttonShowDevTools_Click);
            // 
            // buttonChangeAddress
            // 
            this.buttonChangeAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeAddress.Location = new System.Drawing.Point(702, 50);
            this.buttonChangeAddress.Name = "buttonChangeAddress";
            this.buttonChangeAddress.Size = new System.Drawing.Size(135, 35);
            this.buttonChangeAddress.TabIndex = 2;
            this.buttonChangeAddress.Text = "Change Address";
            this.buttonChangeAddress.UseVisualStyleBackColor = true;
            this.buttonChangeAddress.Click += new System.EventHandler(this.buttonChangeAddress_Click);
            // 
            // buttonCustomHTML
            // 
            this.buttonCustomHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCustomHTML.Location = new System.Drawing.Point(702, 91);
            this.buttonCustomHTML.Name = "buttonCustomHTML";
            this.buttonCustomHTML.Size = new System.Drawing.Size(135, 35);
            this.buttonCustomHTML.TabIndex = 3;
            this.buttonCustomHTML.Text = "Custom HTML";
            this.buttonCustomHTML.UseVisualStyleBackColor = true;
            this.buttonCustomHTML.Click += new System.EventHandler(this.buttonCustomHTML_Click);
            // 
            // buttonLoadLocalHTML
            // 
            this.buttonLoadLocalHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadLocalHTML.Location = new System.Drawing.Point(702, 132);
            this.buttonLoadLocalHTML.Name = "buttonLoadLocalHTML";
            this.buttonLoadLocalHTML.Size = new System.Drawing.Size(135, 35);
            this.buttonLoadLocalHTML.TabIndex = 4;
            this.buttonLoadLocalHTML.Text = "Load HTML from File";
            this.buttonLoadLocalHTML.UseVisualStyleBackColor = true;
            this.buttonLoadLocalHTML.Click += new System.EventHandler(this.buttonLoadLocalHTML_Click);
            // 
            // buttonRegisterCSharpObject
            // 
            this.buttonRegisterCSharpObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegisterCSharpObject.Location = new System.Drawing.Point(702, 173);
            this.buttonRegisterCSharpObject.Name = "buttonRegisterCSharpObject";
            this.buttonRegisterCSharpObject.Size = new System.Drawing.Size(135, 40);
            this.buttonRegisterCSharpObject.TabIndex = 6;
            this.buttonRegisterCSharpObject.Text = "Register Javascript C# Object";
            this.buttonRegisterCSharpObject.UseVisualStyleBackColor = true;
            this.buttonRegisterCSharpObject.Click += new System.EventHandler(this.buttonRegisterCSharpObject_Click);
            // 
            // buttonExecJavaScriptFromWinforms
            // 
            this.buttonExecJavaScriptFromWinforms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecJavaScriptFromWinforms.Location = new System.Drawing.Point(702, 260);
            this.buttonExecJavaScriptFromWinforms.Name = "buttonExecJavaScriptFromWinforms";
            this.buttonExecJavaScriptFromWinforms.Size = new System.Drawing.Size(135, 35);
            this.buttonExecJavaScriptFromWinforms.TabIndex = 7;
            this.buttonExecJavaScriptFromWinforms.Text = "Exec JavaScript from C#";
            this.buttonExecJavaScriptFromWinforms.UseVisualStyleBackColor = true;
            this.buttonExecJavaScriptFromWinforms.Click += new System.EventHandler(this.buttonExecJavaScriptFromWinforms_Click);
            // 
            // buttonHTMLDemos
            // 
            this.buttonHTMLDemos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHTMLDemos.Location = new System.Drawing.Point(702, 383);
            this.buttonHTMLDemos.Name = "buttonHTMLDemos";
            this.buttonHTMLDemos.Size = new System.Drawing.Size(135, 35);
            this.buttonHTMLDemos.TabIndex = 10;
            this.buttonHTMLDemos.Text = "HTML Demos";
            this.buttonHTMLDemos.UseVisualStyleBackColor = true;
            this.buttonHTMLDemos.Click += new System.EventHandler(this.buttonHTMLDemos_Click);
            // 
            // buttonExecCsharpFromJS
            // 
            this.buttonExecCsharpFromJS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecCsharpFromJS.Location = new System.Drawing.Point(702, 219);
            this.buttonExecCsharpFromJS.Name = "buttonExecCsharpFromJS";
            this.buttonExecCsharpFromJS.Size = new System.Drawing.Size(135, 35);
            this.buttonExecCsharpFromJS.TabIndex = 11;
            this.buttonExecCsharpFromJS.Text = "Exec C# from JavaScript";
            this.buttonExecCsharpFromJS.UseVisualStyleBackColor = true;
            this.buttonExecCsharpFromJS.Click += new System.EventHandler(this.buttonExecCsharpFromJS_Click);
            // 
            // buttonReturnDataFromJavaScript
            // 
            this.buttonReturnDataFromJavaScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturnDataFromJavaScript.Location = new System.Drawing.Point(702, 301);
            this.buttonReturnDataFromJavaScript.Name = "buttonReturnDataFromJavaScript";
            this.buttonReturnDataFromJavaScript.Size = new System.Drawing.Size(135, 35);
            this.buttonReturnDataFromJavaScript.TabIndex = 12;
            this.buttonReturnDataFromJavaScript.Text = "In C#, Return Data From JavaScript 1";
            this.buttonReturnDataFromJavaScript.UseVisualStyleBackColor = true;
            this.buttonReturnDataFromJavaScript.Click += new System.EventHandler(this.buttonReturnDataFromJavaScript_Click);
            // 
            // buttonReturnDataFromJavaScript2
            // 
            this.buttonReturnDataFromJavaScript2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturnDataFromJavaScript2.Location = new System.Drawing.Point(702, 342);
            this.buttonReturnDataFromJavaScript2.Name = "buttonReturnDataFromJavaScript2";
            this.buttonReturnDataFromJavaScript2.Size = new System.Drawing.Size(135, 35);
            this.buttonReturnDataFromJavaScript2.TabIndex = 13;
            this.buttonReturnDataFromJavaScript2.Text = "In C#, Return Data From JavaScript 2";
            this.buttonReturnDataFromJavaScript2.UseVisualStyleBackColor = true;
            this.buttonReturnDataFromJavaScript2.Click += new System.EventHandler(this.buttonReturnDataFromJavaScript2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 451);
            this.Controls.Add(this.buttonReturnDataFromJavaScript2);
            this.Controls.Add(this.buttonReturnDataFromJavaScript);
            this.Controls.Add(this.buttonExecCsharpFromJS);
            this.Controls.Add(this.buttonHTMLDemos);
            this.Controls.Add(this.buttonExecJavaScriptFromWinforms);
            this.Controls.Add(this.buttonRegisterCSharpObject);
            this.Controls.Add(this.buttonLoadLocalHTML);
            this.Controls.Add(this.buttonCustomHTML);
            this.Controls.Add(this.buttonChangeAddress);
            this.Controls.Add(this.buttonShowDevTools);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Using HTML as a UI - By Ocean Airdrop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShowDevTools;
        private System.Windows.Forms.Button buttonChangeAddress;
        private System.Windows.Forms.Button buttonCustomHTML;
        private System.Windows.Forms.Button buttonLoadLocalHTML;
        private System.Windows.Forms.Button buttonRegisterCSharpObject;
        private System.Windows.Forms.Button buttonExecJavaScriptFromWinforms;
        private System.Windows.Forms.Button buttonHTMLDemos;
        private System.Windows.Forms.Button buttonExecCsharpFromJS;
        private System.Windows.Forms.Button buttonReturnDataFromJavaScript;
        private System.Windows.Forms.Button buttonReturnDataFromJavaScript2;
    }
}

