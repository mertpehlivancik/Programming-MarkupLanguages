namespace TryCatch
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnKontrolluOnay = new System.Windows.Forms.Button();
            this.btnFinalKontrollu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeger.Location = new System.Drawing.Point(53, 50);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(373, 30);
            this.txtDeger.TabIndex = 0;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(53, 86);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(373, 37);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnKontrolluOnay
            // 
            this.btnKontrolluOnay.Location = new System.Drawing.Point(53, 129);
            this.btnKontrolluOnay.Name = "btnKontrolluOnay";
            this.btnKontrolluOnay.Size = new System.Drawing.Size(373, 37);
            this.btnKontrolluOnay.TabIndex = 2;
            this.btnKontrolluOnay.Text = "Kontrollü Onayla";
            this.btnKontrolluOnay.UseVisualStyleBackColor = true;
            this.btnKontrolluOnay.Click += new System.EventHandler(this.btnKontrolluOnay_Click);
            // 
            // btnFinalKontrollu
            // 
            this.btnFinalKontrollu.Location = new System.Drawing.Point(53, 172);
            this.btnFinalKontrollu.Name = "btnFinalKontrollu";
            this.btnFinalKontrollu.Size = new System.Drawing.Size(373, 40);
            this.btnFinalKontrollu.TabIndex = 3;
            this.btnFinalKontrollu.Tag = "";
            this.btnFinalKontrollu.Text = "Finally Kontrollü Onay";
            this.btnFinalKontrollu.UseVisualStyleBackColor = true;
            this.btnFinalKontrollu.Click += new System.EventHandler(this.btnFinalKontrollu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(500, 359);
            this.Controls.Add(this.btnFinalKontrollu);
            this.Controls.Add(this.btnKontrolluOnay);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtDeger);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnKontrolluOnay;
        private System.Windows.Forms.Button btnFinalKontrollu;
    }
}

