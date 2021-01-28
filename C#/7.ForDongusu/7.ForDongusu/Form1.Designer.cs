namespace _7.ForDongusu
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
            this.btnBirdenBine = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBindenBire = new System.Windows.Forms.Button();
            this.btnAdanZye = new System.Windows.Forms.Button();
            this.btnGauss = new System.Windows.Forms.Button();
            this.lbltoplam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBirdenBine
            // 
            this.btnBirdenBine.Location = new System.Drawing.Point(7, 16);
            this.btnBirdenBine.Name = "btnBirdenBine";
            this.btnBirdenBine.Size = new System.Drawing.Size(166, 47);
            this.btnBirdenBine.TabIndex = 0;
            this.btnBirdenBine.Text = "1\'den 100\'e";
            this.btnBirdenBine.UseVisualStyleBackColor = true;
            this.btnBirdenBine.Click += new System.EventHandler(this.btnBirdenBine_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(183, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 468);
            this.listBox1.TabIndex = 1;
            // 
            // btnBindenBire
            // 
            this.btnBindenBire.Location = new System.Drawing.Point(7, 72);
            this.btnBindenBire.Name = "btnBindenBire";
            this.btnBindenBire.Size = new System.Drawing.Size(165, 47);
            this.btnBindenBire.TabIndex = 2;
            this.btnBindenBire.Text = "1000\'den 1\'e";
            this.btnBindenBire.UseVisualStyleBackColor = true;
            this.btnBindenBire.Click += new System.EventHandler(this.btnBindenBire_Click);
            // 
            // btnAdanZye
            // 
            this.btnAdanZye.Location = new System.Drawing.Point(7, 125);
            this.btnAdanZye.Name = "btnAdanZye";
            this.btnAdanZye.Size = new System.Drawing.Size(166, 42);
            this.btnAdanZye.TabIndex = 3;
            this.btnAdanZye.Text = "A\'dan Z\'ye";
            this.btnAdanZye.UseVisualStyleBackColor = true;
            this.btnAdanZye.Click += new System.EventHandler(this.btnAdanZye_Click);
            // 
            // btnGauss
            // 
            this.btnGauss.Location = new System.Drawing.Point(7, 173);
            this.btnGauss.Name = "btnGauss";
            this.btnGauss.Size = new System.Drawing.Size(170, 42);
            this.btnGauss.TabIndex = 4;
            this.btnGauss.Text = "Gauss";
            this.btnGauss.UseVisualStyleBackColor = true;
            this.btnGauss.Click += new System.EventHandler(this.btnGauss_Click);
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.Location = new System.Drawing.Point(48, 232);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(89, 17);
            this.lbltoplam.TabIndex = 5;
            this.lbltoplam.Text = "GaussSonuc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(438, 499);
            this.Controls.Add(this.lbltoplam);
            this.Controls.Add(this.btnGauss);
            this.Controls.Add(this.btnAdanZye);
            this.Controls.Add(this.btnBindenBire);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBirdenBine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBirdenBine;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBindenBire;
        private System.Windows.Forms.Button btnAdanZye;
        private System.Windows.Forms.Button btnGauss;
        private System.Windows.Forms.Label lbltoplam;
    }
}

