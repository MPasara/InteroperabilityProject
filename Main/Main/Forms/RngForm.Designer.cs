namespace Main.Forms
{
    partial class RngForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChooseXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(255, 40);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 56);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChooseXml
            // 
            this.btnChooseXml.Location = new System.Drawing.Point(33, 40);
            this.btnChooseXml.Name = "btnChooseXml";
            this.btnChooseXml.Size = new System.Drawing.Size(146, 56);
            this.btnChooseXml.TabIndex = 4;
            this.btnChooseXml.Text = "CHOOSE AND POST XML FILE ";
            this.btnChooseXml.UseVisualStyleBackColor = true;
            this.btnChooseXml.Click += new System.EventHandler(this.btnChooseXml_Click);
            // 
            // RngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 135);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChooseXml);
            this.Name = "RngForm";
            this.Text = "RngForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChooseXml;
    }
}