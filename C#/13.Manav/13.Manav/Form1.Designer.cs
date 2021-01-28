namespace _13.Manav
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
            this.cboxUrunler = new System.Windows.Forms.ComboBox();
            this.listboxSepet = new System.Windows.Forms.ListBox();
            this.listboxUrunler = new System.Windows.Forms.ListBox();
            this.numKilo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKilo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxUrunler
            // 
            this.cboxUrunler.FormattingEnabled = true;
            this.cboxUrunler.Items.AddRange(new object[] {
            "Baklagiller",
            "Turuncgiller"});
            this.cboxUrunler.Location = new System.Drawing.Point(27, 87);
            this.cboxUrunler.Name = "cboxUrunler";
            this.cboxUrunler.Size = new System.Drawing.Size(199, 24);
            this.cboxUrunler.TabIndex = 0;
            this.cboxUrunler.SelectedIndexChanged += new System.EventHandler(this.cboxUrunler_SelectedIndexChanged);
            // 
            // listboxSepet
            // 
            this.listboxSepet.FormattingEnabled = true;
            this.listboxSepet.ItemHeight = 16;
            this.listboxSepet.Location = new System.Drawing.Point(27, 136);
            this.listboxSepet.Name = "listboxSepet";
            this.listboxSepet.Size = new System.Drawing.Size(360, 212);
            this.listboxSepet.TabIndex = 1;
            this.listboxSepet.DoubleClick += new System.EventHandler(this.listboxSepet_DoubleClick);
            // 
            // listboxUrunler
            // 
            this.listboxUrunler.FormattingEnabled = true;
            this.listboxUrunler.ItemHeight = 16;
            this.listboxUrunler.Location = new System.Drawing.Point(460, 74);
            this.listboxUrunler.Name = "listboxUrunler";
            this.listboxUrunler.Size = new System.Drawing.Size(277, 244);
            this.listboxUrunler.TabIndex = 2;
            // 
            // numKilo
            // 
            this.numKilo.Location = new System.Drawing.Point(531, 337);
            this.numKilo.Name = "numKilo";
            this.numKilo.Size = new System.Drawing.Size(206, 22);
            this.numKilo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kilo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Grubunu Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Meyve ve Sebzeler";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(30, 376);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(706, 85);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "button1";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(27, 467);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(710, 84);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "button1";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(27, 557);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(709, 88);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "button1";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(764, 670);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numKilo);
            this.Controls.Add(this.listboxUrunler);
            this.Controls.Add(this.listboxSepet);
            this.Controls.Add(this.cboxUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxUrunler;
        private System.Windows.Forms.ListBox listboxSepet;
        private System.Windows.Forms.ListBox listboxUrunler;
        private System.Windows.Forms.NumericUpDown numKilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
    }
}

