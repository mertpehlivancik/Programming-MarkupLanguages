namespace _10.Arrays
{
    partial class Form4
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
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSehirler = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnArraySorting = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(39, 40);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(390, 46);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSehirler
            // 
            this.txtSehirler.Location = new System.Drawing.Point(39, 12);
            this.txtSehirler.Name = "txtSehirler";
            this.txtSehirler.Size = new System.Drawing.Size(390, 22);
            this.txtSehirler.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(457, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 212);
            this.listBox1.TabIndex = 2;
            // 
            // btnArraySorting
            // 
            this.btnArraySorting.Location = new System.Drawing.Point(39, 92);
            this.btnArraySorting.Name = "btnArraySorting";
            this.btnArraySorting.Size = new System.Drawing.Size(390, 49);
            this.btnArraySorting.TabIndex = 3;
            this.btnArraySorting.Text = "Sort";
            this.btnArraySorting.UseVisualStyleBackColor = true;
            this.btnArraySorting.Click += new System.EventHandler(this.btnArraySorting_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(39, 147);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(390, 49);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(782, 233);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnArraySorting);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtSehirler);
            this.Controls.Add(this.btnFind);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSehirler;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnArraySorting;
        private System.Windows.Forms.Button btnReverse;
    }
}