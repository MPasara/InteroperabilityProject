namespace Main
{
    partial class DhmzForm
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
            this.tbCityName = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.btnGetTemperature = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCityName
            // 
            this.tbCityName.Location = new System.Drawing.Point(140, 44);
            this.tbCityName.Name = "tbCityName";
            this.tbCityName.Size = new System.Drawing.Size(259, 22);
            this.tbCityName.TabIndex = 0;
            // 
            // tbTemperature
            // 
            this.tbTemperature.BackColor = System.Drawing.Color.LightGray;
            this.tbTemperature.ForeColor = System.Drawing.Color.DarkRed;
            this.tbTemperature.Location = new System.Drawing.Point(140, 125);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(259, 22);
            this.tbTemperature.TabIndex = 1;
            // 
            // btnGetTemperature
            // 
            this.btnGetTemperature.Location = new System.Drawing.Point(140, 190);
            this.btnGetTemperature.Name = "btnGetTemperature";
            this.btnGetTemperature.Size = new System.Drawing.Size(107, 39);
            this.btnGetTemperature.TabIndex = 2;
            this.btnGetTemperature.Text = "Get data";
            this.btnGetTemperature.UseVisualStyleBackColor = true;
            this.btnGetTemperature.Click += new System.EventHandler(this.btnGetTemperature_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperature:";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(292, 190);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(107, 39);
            this.btnClearForm.TabIndex = 5;
            this.btnClearForm.Text = "Clear form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbInfo.Location = new System.Drawing.Point(89, 238);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 17);
            this.lbInfo.TabIndex = 6;
            // 
            // DhmzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 275);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetTemperature);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.tbCityName);
            this.Name = "DhmzForm";
            this.Text = "Dhmz";
            this.Load += new System.EventHandler(this.DhmzForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCityName;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.Button btnGetTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Label lbInfo;
    }
}