namespace _7.ForDongusu
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
            this.lstBoxTakimlar = new System.Windows.Forms.ListBox();
            this.btnTakimlar = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGez = new System.Windows.Forms.Button();
            this.btnSayilar = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxTakimlar
            // 
            this.lstBoxTakimlar.FormattingEnabled = true;
            this.lstBoxTakimlar.ItemHeight = 16;
            this.lstBoxTakimlar.Location = new System.Drawing.Point(22, 72);
            this.lstBoxTakimlar.Name = "lstBoxTakimlar";
            this.lstBoxTakimlar.Size = new System.Drawing.Size(223, 484);
            this.lstBoxTakimlar.TabIndex = 0;
            this.lstBoxTakimlar.Click += new System.EventHandler(this.lstBoxTakimlar_Click);
            // 
            // btnTakimlar
            // 
            this.btnTakimlar.Location = new System.Drawing.Point(278, 13);
            this.btnTakimlar.Name = "btnTakimlar";
            this.btnTakimlar.Size = new System.Drawing.Size(233, 52);
            this.btnTakimlar.TabIndex = 1;
            this.btnTakimlar.Text = "Takimlari Göster";
            this.btnTakimlar.UseVisualStyleBackColor = true;
            this.btnTakimlar.Click += new System.EventHandler(this.btnTakimlar_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(24, 13);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(220, 48);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGez
            // 
            this.btnGez.Location = new System.Drawing.Point(278, 71);
            this.btnGez.Name = "btnGez";
            this.btnGez.Size = new System.Drawing.Size(233, 49);
            this.btnGez.TabIndex = 3;
            this.btnGez.Text = "Gez";
            this.btnGez.UseVisualStyleBackColor = true;
            this.btnGez.Click += new System.EventHandler(this.btnGez_Click);
            // 
            // btnSayilar
            // 
            this.btnSayilar.Location = new System.Drawing.Point(278, 126);
            this.btnSayilar.Name = "btnSayilar";
            this.btnSayilar.Size = new System.Drawing.Size(233, 49);
            this.btnSayilar.TabIndex = 4;
            this.btnSayilar.Text = "Sayilar";
            this.btnSayilar.UseVisualStyleBackColor = true;
            this.btnSayilar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(278, 181);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(231, 53);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(559, 575);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.btnGez);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnTakimlar);
            this.Controls.Add(this.lstBoxTakimlar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxTakimlar;
        private System.Windows.Forms.Button btnTakimlar;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGez;
        private System.Windows.Forms.Button btnSayilar;
        private System.Windows.Forms.Button btnRandom;
    }
}