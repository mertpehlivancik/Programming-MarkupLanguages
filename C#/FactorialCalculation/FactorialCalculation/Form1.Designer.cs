namespace FactorialCalculation
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
            this.btnFactorialCalculation = new System.Windows.Forms.Button();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFactorialCalculation
            // 
            this.btnFactorialCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorialCalculation.Location = new System.Drawing.Point(46, 112);
            this.btnFactorialCalculation.Name = "btnFactorialCalculation";
            this.btnFactorialCalculation.Size = new System.Drawing.Size(511, 135);
            this.btnFactorialCalculation.TabIndex = 0;
            this.btnFactorialCalculation.Text = "Calculate Factorial";
            this.btnFactorialCalculation.UseVisualStyleBackColor = true;
            this.btnFactorialCalculation.Click += new System.EventHandler(this.btnFactorialCalculation_Click);
            // 
            // txtFactorial
            // 
            this.txtFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactorial.Location = new System.Drawing.Point(296, 53);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.Size = new System.Drawing.Size(258, 38);
            this.txtFactorial.TabIndex = 1;
            this.txtFactorial.TextChanged += new System.EventHandler(this.txtFactorial_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter Number:";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(106, 19);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(182, 29);
            this.lblKey.TabIndex = 3;
            this.lblKey.Text = "I am not Robot";
            this.lblKey.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Copyright © 2017 Tüm Hakları Saklıdır.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(602, 280);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFactorial);
            this.Controls.Add(this.btnFactorialCalculation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFactorialCalculation;
        private System.Windows.Forms.TextBox txtFactorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label label2;
    }
}

