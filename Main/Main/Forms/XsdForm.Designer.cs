namespace Main.Forms
{
    partial class XsdForm
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
            this.btnChooseXml = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseXml
            // 
            this.btnChooseXml.Location = new System.Drawing.Point(61, 48);
            this.btnChooseXml.Name = "btnChooseXml";
            this.btnChooseXml.Size = new System.Drawing.Size(146, 56);
            this.btnChooseXml.TabIndex = 0;
            this.btnChooseXml.Text = "CHOOSE AND POST XML FILE ";
            this.btnChooseXml.UseVisualStyleBackColor = true;
            this.btnChooseXml.Click += new System.EventHandler(this.btnChooseXml_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(268, 48);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 56);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // XsdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 143);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChooseXml);
            this.Name = "XsdForm";
            this.Text = "XsdForm";
            this.Load += new System.EventHandler(this.XsdForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseXml;
        private System.Windows.Forms.Button btnExit;
    }
}