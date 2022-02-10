namespace Main
{
    partial class StartForm
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
            this.btnXsd = new System.Windows.Forms.Button();
            this.btnRng = new System.Windows.Forms.Button();
            this.btnSoap = new System.Windows.Forms.Button();
            this.btnDhmz = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXsd
            // 
            this.btnXsd.Location = new System.Drawing.Point(42, 36);
            this.btnXsd.Name = "btnXsd";
            this.btnXsd.Size = new System.Drawing.Size(192, 54);
            this.btnXsd.TabIndex = 0;
            this.btnXsd.Text = "XSD";
            this.btnXsd.UseVisualStyleBackColor = true;
            this.btnXsd.Click += new System.EventHandler(this.btnXsd_Click);
            // 
            // btnRng
            // 
            this.btnRng.Location = new System.Drawing.Point(279, 36);
            this.btnRng.Name = "btnRng";
            this.btnRng.Size = new System.Drawing.Size(192, 54);
            this.btnRng.TabIndex = 1;
            this.btnRng.Text = "RNG";
            this.btnRng.UseVisualStyleBackColor = true;
            this.btnRng.Click += new System.EventHandler(this.btnRng_Click);
            // 
            // btnSoap
            // 
            this.btnSoap.Location = new System.Drawing.Point(42, 129);
            this.btnSoap.Name = "btnSoap";
            this.btnSoap.Size = new System.Drawing.Size(192, 54);
            this.btnSoap.TabIndex = 2;
            this.btnSoap.Text = "SOAP";
            this.btnSoap.UseVisualStyleBackColor = true;
            this.btnSoap.Click += new System.EventHandler(this.btnSoap_Click);
            // 
            // btnDhmz
            // 
            this.btnDhmz.Location = new System.Drawing.Point(279, 129);
            this.btnDhmz.Name = "btnDhmz";
            this.btnDhmz.Size = new System.Drawing.Size(192, 54);
            this.btnDhmz.TabIndex = 4;
            this.btnDhmz.Text = "XML-RPC";
            this.btnDhmz.UseVisualStyleBackColor = true;
            this.btnDhmz.Click += new System.EventHandler(this.btnDhmz_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(42, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(429, 54);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 316);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDhmz);
            this.Controls.Add(this.btnSoap);
            this.Controls.Add(this.btnRng);
            this.Controls.Add(this.btnXsd);
            this.Name = "StartForm";
            this.Text = "IIS";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXsd;
        private System.Windows.Forms.Button btnRng;
        private System.Windows.Forms.Button btnSoap;
        private System.Windows.Forms.Button btnDhmz;
        private System.Windows.Forms.Button btnExit;
    }
}

