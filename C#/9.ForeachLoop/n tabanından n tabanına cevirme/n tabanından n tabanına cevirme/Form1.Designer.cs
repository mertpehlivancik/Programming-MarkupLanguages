namespace n_tabanından_n_tabanına_cevirme
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
            this.btnCevir = new System.Windows.Forms.Button();
            this.txtOrginalSayi = new System.Windows.Forms.TextBox();
            this.txtOrginalSayiTabani = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtCevirTaban = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCevir
            // 
            this.btnCevir.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCevir.Location = new System.Drawing.Point(31, 337);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(427, 110);
            this.btnCevir.TabIndex = 0;
            this.btnCevir.Text = "Cevir";
            this.btnCevir.UseVisualStyleBackColor = true;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // txtOrginalSayi
            // 
            this.txtOrginalSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrginalSayi.Location = new System.Drawing.Point(177, 88);
            this.txtOrginalSayi.Name = "txtOrginalSayi";
            this.txtOrginalSayi.Size = new System.Drawing.Size(281, 56);
            this.txtOrginalSayi.TabIndex = 1;
            // 
            // txtOrginalSayiTabani
            // 
            this.txtOrginalSayiTabani.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrginalSayiTabani.Location = new System.Drawing.Point(177, 12);
            this.txtOrginalSayiTabani.Name = "txtOrginalSayiTabani";
            this.txtOrginalSayiTabani.Size = new System.Drawing.Size(281, 56);
            this.txtOrginalSayiTabani.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sonuc:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(198, 259);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(271, 55);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "*************";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCevirTaban
            // 
            this.txtCevirTaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCevirTaban.Location = new System.Drawing.Point(177, 163);
            this.txtCevirTaban.Name = "txtCevirTaban";
            this.txtCevirTaban.Size = new System.Drawing.Size(281, 56);
            this.txtCevirTaban.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 475);
            this.Controls.Add(this.txtCevirTaban);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrginalSayiTabani);
            this.Controls.Add(this.txtOrginalSayi);
            this.Controls.Add(this.btnCevir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCevir;
        private System.Windows.Forms.TextBox txtOrginalSayi;
        private System.Windows.Forms.TextBox txtCevirilecekTaban;
        private System.Windows.Forms.TextBox txtOrginalSayiTabani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtCevirTaban;
    }
}

