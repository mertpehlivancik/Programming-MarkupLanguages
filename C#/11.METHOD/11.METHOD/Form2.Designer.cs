namespace _11.METHOD
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
            this.numSayi1 = new System.Windows.Forms.NumericUpDown();
            this.numSayi2 = new System.Windows.Forms.NumericUpDown();
            this.btnTopla = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnCiftTek = new System.Windows.Forms.Button();
            this.btnRandomSayiTekCift = new System.Windows.Forms.Button();
            this.cbRenkler = new System.Windows.Forms.ComboBox();
            this.btnRandomColor = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMailDomain = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi2)).BeginInit();
            this.SuspendLayout();
            // 
            // numSayi1
            // 
            this.numSayi1.Location = new System.Drawing.Point(26, 29);
            this.numSayi1.Name = "numSayi1";
            this.numSayi1.Size = new System.Drawing.Size(212, 22);
            this.numSayi1.TabIndex = 0;
            // 
            // numSayi2
            // 
            this.numSayi2.Location = new System.Drawing.Point(260, 29);
            this.numSayi2.Name = "numSayi2";
            this.numSayi2.Size = new System.Drawing.Size(212, 22);
            this.numSayi2.TabIndex = 1;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(26, 66);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(445, 47);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "Toplam";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(26, 131);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(212, 22);
            this.txtSayi.TabIndex = 3;
            // 
            // btnCiftTek
            // 
            this.btnCiftTek.Location = new System.Drawing.Point(260, 130);
            this.btnCiftTek.Name = "btnCiftTek";
            this.btnCiftTek.Size = new System.Drawing.Size(212, 23);
            this.btnCiftTek.TabIndex = 4;
            this.btnCiftTek.Text = "TekCift";
            this.btnCiftTek.UseVisualStyleBackColor = true;
            this.btnCiftTek.Click += new System.EventHandler(this.btnCiftTek_Click);
            // 
            // btnRandomSayiTekCift
            // 
            this.btnRandomSayiTekCift.Location = new System.Drawing.Point(26, 168);
            this.btnRandomSayiTekCift.Name = "btnRandomSayiTekCift";
            this.btnRandomSayiTekCift.Size = new System.Drawing.Size(445, 40);
            this.btnRandomSayiTekCift.TabIndex = 5;
            this.btnRandomSayiTekCift.Text = "RandomSayiTekCift";
            this.btnRandomSayiTekCift.UseVisualStyleBackColor = true;
            this.btnRandomSayiTekCift.Click += new System.EventHandler(this.btnRandomSayiTekCift_Click);
            // 
            // cbRenkler
            // 
            this.cbRenkler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRenkler.FormattingEnabled = true;
            this.cbRenkler.Items.AddRange(new object[] {
            "Blue",
            "Black",
            "Yellow",
            "Red",
            "Green"});
            this.cbRenkler.Location = new System.Drawing.Point(26, 214);
            this.cbRenkler.Name = "cbRenkler";
            this.cbRenkler.Size = new System.Drawing.Size(446, 24);
            this.cbRenkler.TabIndex = 6;
            this.cbRenkler.SelectedIndexChanged += new System.EventHandler(this.cbRenkler_SelectedIndexChanged);
            // 
            // btnRandomColor
            // 
            this.btnRandomColor.Location = new System.Drawing.Point(26, 246);
            this.btnRandomColor.Name = "btnRandomColor";
            this.btnRandomColor.Size = new System.Drawing.Size(444, 32);
            this.btnRandomColor.TabIndex = 7;
            this.btnRandomColor.Text = "RandomColor";
            this.btnRandomColor.UseVisualStyleBackColor = true;
            this.btnRandomColor.Click += new System.EventHandler(this.btnRandomColor_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(26, 284);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(445, 34);
            this.btnBackColor.TabIndex = 8;
            this.btnBackColor.Text = "Backcolor";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(197, 330);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(87, 80);
            this.btnOlustur.TabIndex = 9;
            this.btnOlustur.Text = "Olustur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "AD:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(89, 331);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 11;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(89, 359);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "SOYAD:";
            // 
            // cbMailDomain
            // 
            this.cbMailDomain.FormattingEnabled = true;
            this.cbMailDomain.Items.AddRange(new object[] {
            "@gmail.com",
            "@outlook.com",
            "@yahoo.com"});
            this.cbMailDomain.Location = new System.Drawing.Point(26, 387);
            this.cbMailDomain.Name = "cbMailDomain";
            this.cbMailDomain.Size = new System.Drawing.Size(163, 24);
            this.cbMailDomain.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(516, 531);
            this.Controls.Add(this.cbMailDomain);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.btnRandomColor);
            this.Controls.Add(this.cbRenkler);
            this.Controls.Add(this.btnRandomSayiTekCift);
            this.Controls.Add(this.btnCiftTek);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.numSayi2);
            this.Controls.Add(this.numSayi1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnBackColor_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnTopla_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnRandomColor_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void cbRenkler_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnRandomSayiTekCift_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnCiftTek_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSayi1;
        private System.Windows.Forms.NumericUpDown numSayi2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnCiftTek;
        private System.Windows.Forms.Button btnRandomSayiTekCift;
        private System.Windows.Forms.ComboBox cbRenkler;
        private System.Windows.Forms.Button btnRandomColor;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMailDomain;
    }
}