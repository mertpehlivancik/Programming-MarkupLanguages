namespace _15.Collection
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnListCreate = new System.Windows.Forms.Button();
            this.btnYillariEkle = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(348, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 532);
            this.listBox1.TabIndex = 0;
            // 
            // btnListCreate
            // 
            this.btnListCreate.Location = new System.Drawing.Point(83, 30);
            this.btnListCreate.Name = "btnListCreate";
            this.btnListCreate.Size = new System.Drawing.Size(166, 32);
            this.btnListCreate.TabIndex = 1;
            this.btnListCreate.Text = "CreateList";
            this.btnListCreate.UseVisualStyleBackColor = true;
            this.btnListCreate.Click += new System.EventHandler(this.btnListCreate_Click);
            // 
            // btnYillariEkle
            // 
            this.btnYillariEkle.Location = new System.Drawing.Point(83, 68);
            this.btnYillariEkle.Name = "btnYillariEkle";
            this.btnYillariEkle.Size = new System.Drawing.Size(166, 36);
            this.btnYillariEkle.TabIndex = 2;
            this.btnYillariEkle.Text = "YillariEkle";
            this.btnYillariEkle.UseVisualStyleBackColor = true;
            this.btnYillariEkle.Click += new System.EventHandler(this.btnYillariEkle_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(348, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(375, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(786, 627);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnYillariEkle);
            this.Controls.Add(this.btnListCreate);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnListCreate;
        private System.Windows.Forms.Button btnYillariEkle;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

