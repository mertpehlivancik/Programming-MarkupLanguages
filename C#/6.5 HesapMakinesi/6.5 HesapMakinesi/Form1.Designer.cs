namespace _6._5_HesapMakinesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.cboxHesapSecim = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayi1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayi2";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(122, 42);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(165, 22);
            this.txtSayi1.TabIndex = 2;
            this.txtSayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(122, 81);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(165, 22);
            this.txtSayi2.TabIndex = 3;
            // 
            // cboxHesapSecim
            // 
            this.cboxHesapSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxHesapSecim.FormattingEnabled = true;
            this.cboxHesapSecim.Location = new System.Drawing.Point(74, 112);
            this.cboxHesapSecim.Name = "cboxHesapSecim";
            this.cboxHesapSecim.Size = new System.Drawing.Size(212, 24);
            this.cboxHesapSecim.TabIndex = 4;
            this.cboxHesapSecim.SelectedIndexChanged += new System.EventHandler(this.cboxHesapSecim_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(334, 188);
            this.Controls.Add(this.cboxHesapSecim);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.ComboBox cboxHesapSecim;
    }
}

