namespace _6._8_HesapMakinesiYeni
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
            this.numSayi1 = new System.Windows.Forms.NumericUpDown();
            this.numSayi2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi2)).BeginInit();
            this.SuspendLayout();
            // 
            // numSayi1
            // 
            this.numSayi1.Location = new System.Drawing.Point(54, 31);
            this.numSayi1.Name = "numSayi1";
            this.numSayi1.Size = new System.Drawing.Size(238, 22);
            this.numSayi1.TabIndex = 0;
            this.numSayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSayi1.ValueChanged += new System.EventHandler(this.numSayi1_ValueChanged);
            // 
            // numSayi2
            // 
            this.numSayi2.Location = new System.Drawing.Point(54, 68);
            this.numSayi2.Name = "numSayi2";
            this.numSayi2.Size = new System.Drawing.Size(238, 22);
            this.numSayi2.TabIndex = 1;
            this.numSayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSayi2.ValueChanged += new System.EventHandler(this.numSayi1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(74, 160);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(52, 17);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Sonuc:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(132, 160);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(16, 17);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(344, 228);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numSayi2);
            this.Controls.Add(this.numSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSayi1;
        private System.Windows.Forms.NumericUpDown numSayi2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblSonuc;
    }
}

