namespace veritürleriörnekleri1
{
    partial class Form1
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lblSonuç = new System.Windows.Forms.Label();
            this.btnHesap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(331, 133);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 0;
            // 
            // lblSonuç
            // 
            this.lblSonuç.AutoSize = true;
            this.lblSonuç.Location = new System.Drawing.Point(458, 133);
            this.lblSonuç.Name = "lblSonuç";
            this.lblSonuç.Size = new System.Drawing.Size(27, 13);
            this.lblSonuç.TabIndex = 1;
            this.lblSonuç.Text = "*****";
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(212, 133);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(86, 31);
            this.btnHesap.TabIndex = 2;
            this.btnHesap.Text = "hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.lblSonuç);
            this.Controls.Add(this.txtSayi);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label lblSonuç;
        private System.Windows.Forms.Button btnHesap;
    }
}

