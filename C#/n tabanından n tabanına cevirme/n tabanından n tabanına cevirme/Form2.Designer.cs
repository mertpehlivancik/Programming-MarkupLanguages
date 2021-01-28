namespace n_tabanından_n_tabanına_cevirme
{
    partial class Form2
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
            this.txtCevirTaban = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrginalSayiTabani = new System.Windows.Forms.TextBox();
            this.txtOrginalSayi = new System.Windows.Forms.TextBox();
            this.btnCevir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCevirTaban
            // 
            this.txtCevirTaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCevirTaban.Location = new System.Drawing.Point(253, 241);
            this.txtCevirTaban.Name = "txtCevirTaban";
            this.txtCevirTaban.Size = new System.Drawing.Size(281, 56);
            this.txtCevirTaban.TabIndex = 12;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(274, 337);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(271, 55);
            this.lblSonuc.TabIndex = 11;
            this.lblSonuc.Text = "*************";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sonuc:";
            // 
            // txtOrginalSayiTabani
            // 
            this.txtOrginalSayiTabani.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrginalSayiTabani.Location = new System.Drawing.Point(253, 90);
            this.txtOrginalSayiTabani.Name = "txtOrginalSayiTabani";
            this.txtOrginalSayiTabani.Size = new System.Drawing.Size(281, 56);
            this.txtOrginalSayiTabani.TabIndex = 9;
            // 
            // txtOrginalSayi
            // 
            this.txtOrginalSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrginalSayi.Location = new System.Drawing.Point(253, 166);
            this.txtOrginalSayi.Name = "txtOrginalSayi";
            this.txtOrginalSayi.Size = new System.Drawing.Size(281, 56);
            this.txtOrginalSayi.TabIndex = 8;
            // 
            // btnCevir
            // 
            this.btnCevir.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCevir.Location = new System.Drawing.Point(107, 415);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(427, 110);
            this.btnCevir.TabIndex = 7;
            this.btnCevir.Text = "Cevir";
            this.btnCevir.UseVisualStyleBackColor = true;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 685);
            this.Controls.Add(this.txtCevirTaban);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrginalSayiTabani);
            this.Controls.Add(this.txtOrginalSayi);
            this.Controls.Add(this.btnCevir);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCevirTaban;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrginalSayiTabani;
        private System.Windows.Forms.TextBox txtOrginalSayi;
        private System.Windows.Forms.Button btnCevir;
    }
}