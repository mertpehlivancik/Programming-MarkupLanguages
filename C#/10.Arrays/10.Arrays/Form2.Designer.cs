namespace _10.Arrays
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
            this.btnSonEleman = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRastgeleElemanGetir = new System.Windows.Forms.Button();
            this.btnEkleTopla = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSonEleman
            // 
            this.btnSonEleman.Location = new System.Drawing.Point(12, 12);
            this.btnSonEleman.Name = "btnSonEleman";
            this.btnSonEleman.Size = new System.Drawing.Size(403, 44);
            this.btnSonEleman.TabIndex = 0;
            this.btnSonEleman.Text = "SonElemanıGetir";
            this.btnSonEleman.UseVisualStyleBackColor = true;
            this.btnSonEleman.Click += new System.EventHandler(this.btnSonEleman_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(434, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRastgeleElemanGetir
            // 
            this.btnRastgeleElemanGetir.Location = new System.Drawing.Point(12, 62);
            this.btnRastgeleElemanGetir.Name = "btnRastgeleElemanGetir";
            this.btnRastgeleElemanGetir.Size = new System.Drawing.Size(403, 57);
            this.btnRastgeleElemanGetir.TabIndex = 2;
            this.btnRastgeleElemanGetir.Text = "Random";
            this.btnRastgeleElemanGetir.UseVisualStyleBackColor = true;
            this.btnRastgeleElemanGetir.Click += new System.EventHandler(this.btnRastgeleElemanGetir_Click);
            // 
            // btnEkleTopla
            // 
            this.btnEkleTopla.Location = new System.Drawing.Point(12, 125);
            this.btnEkleTopla.Name = "btnEkleTopla";
            this.btnEkleTopla.Size = new System.Drawing.Size(403, 57);
            this.btnEkleTopla.TabIndex = 3;
            this.btnEkleTopla.Text = "EkleTopla";
            this.btnEkleTopla.UseVisualStyleBackColor = true;
            this.btnEkleTopla.Click += new System.EventHandler(this.btnEkleTopla_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(446, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 324);
            this.listBox1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(780, 591);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEkleTopla);
            this.Controls.Add(this.btnRastgeleElemanGetir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSonEleman);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSonEleman;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRastgeleElemanGetir;
        private System.Windows.Forms.Button btnEkleTopla;
        private System.Windows.Forms.ListBox listBox1;
    }
}