namespace fibonacciAlgoritm
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
            this.components = new System.ComponentModel.Container();
            this.btnFindFibonacci = new System.Windows.Forms.Button();
            this.txtFibonacci = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindFibonacci
            // 
            this.btnFindFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindFibonacci.Location = new System.Drawing.Point(30, 392);
            this.btnFindFibonacci.Name = "btnFindFibonacci";
            this.btnFindFibonacci.Size = new System.Drawing.Size(427, 83);
            this.btnFindFibonacci.TabIndex = 0;
            this.btnFindFibonacci.Text = "Find";
            this.btnFindFibonacci.UseVisualStyleBackColor = true;
            this.btnFindFibonacci.Click += new System.EventHandler(this.btnFindFibonacci_Click);
            // 
            // txtFibonacci
            // 
            this.txtFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFibonacci.Location = new System.Drawing.Point(30, 329);
            this.txtFibonacci.Name = "txtFibonacci";
            this.txtFibonacci.Size = new System.Drawing.Size(427, 38);
            this.txtFibonacci.TabIndex = 1;
            this.txtFibonacci.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(30, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(427, 292);
            this.listBox1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Copyright © 2017 Tüm Hakları Saklıdır.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(488, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtFibonacci);
            this.Controls.Add(this.btnFindFibonacci);
            this.Name = "Form1";
            this.Text = "Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindFibonacci;
        private System.Windows.Forms.TextBox txtFibonacci;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

