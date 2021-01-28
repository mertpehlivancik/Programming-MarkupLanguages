namespace _6.SwichCase
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
            this.cboxMevsimler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboxMevsimler
            // 
            this.cboxMevsimler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMevsimler.FormattingEnabled = true;
            this.cboxMevsimler.Location = new System.Drawing.Point(85, 44);
            this.cboxMevsimler.Name = "cboxMevsimler";
            this.cboxMevsimler.Size = new System.Drawing.Size(425, 24);
            this.cboxMevsimler.TabIndex = 0;
            this.cboxMevsimler.SelectedIndexChanged += new System.EventHandler(this.cboxMevsimler_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(598, 395);
            this.Controls.Add(this.cboxMevsimler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxMevsimler;
    }
}

