namespace RefAndOutParameters
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
            this.btnDeneme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeneme
            // 
            this.btnDeneme.Location = new System.Drawing.Point(68, 40);
            this.btnDeneme.Name = "btnDeneme";
            this.btnDeneme.Size = new System.Drawing.Size(333, 73);
            this.btnDeneme.TabIndex = 0;
            this.btnDeneme.Text = "button1";
            this.btnDeneme.UseVisualStyleBackColor = true;
            this.btnDeneme.Click += new System.EventHandler(this.btnDeneme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(467, 361);
            this.Controls.Add(this.btnDeneme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeneme;
    }
}

