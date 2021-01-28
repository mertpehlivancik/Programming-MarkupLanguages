namespace ForeachLoop
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
            this.btnShow = new System.Windows.Forms.Button();
            this.lstBoxOgrenciler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(42, 316);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(495, 49);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lstBoxOgrenciler
            // 
            this.lstBoxOgrenciler.FormattingEnabled = true;
            this.lstBoxOgrenciler.ItemHeight = 16;
            this.lstBoxOgrenciler.Location = new System.Drawing.Point(42, 31);
            this.lstBoxOgrenciler.Name = "lstBoxOgrenciler";
            this.lstBoxOgrenciler.Size = new System.Drawing.Size(495, 260);
            this.lstBoxOgrenciler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(584, 395);
            this.Controls.Add(this.lstBoxOgrenciler);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lstBoxOgrenciler;
    }
}

