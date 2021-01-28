namespace _12.MathLibray
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
            this.btnPi = new System.Windows.Forms.Button();
            this.btnMutlak = new System.Windows.Forms.Button();
            this.btnFloor = new System.Windows.Forms.Button();
            this.btnCeiling = new System.Windows.Forms.Button();
            this.btnRound = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnUst = new System.Windows.Forms.Button();
            this.txtUst = new System.Windows.Forms.TextBox();
            this.txtTaban = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(25, 12);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(132, 28);
            this.btnPi.TabIndex = 0;
            this.btnPi.Text = "Pi Sayisi";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnMutlak
            // 
            this.btnMutlak.Location = new System.Drawing.Point(25, 46);
            this.btnMutlak.Name = "btnMutlak";
            this.btnMutlak.Size = new System.Drawing.Size(132, 28);
            this.btnMutlak.TabIndex = 1;
            this.btnMutlak.Text = "Mutlak Değer";
            this.btnMutlak.UseVisualStyleBackColor = true;
            this.btnMutlak.Click += new System.EventHandler(this.btnMutlak_Click);
            // 
            // btnFloor
            // 
            this.btnFloor.Location = new System.Drawing.Point(25, 80);
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.Size = new System.Drawing.Size(132, 28);
            this.btnFloor.TabIndex = 2;
            this.btnFloor.Text = "Floor";
            this.btnFloor.UseVisualStyleBackColor = true;
            this.btnFloor.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // btnCeiling
            // 
            this.btnCeiling.Location = new System.Drawing.Point(25, 114);
            this.btnCeiling.Name = "btnCeiling";
            this.btnCeiling.Size = new System.Drawing.Size(132, 28);
            this.btnCeiling.TabIndex = 3;
            this.btnCeiling.Text = "Ceiling";
            this.btnCeiling.UseVisualStyleBackColor = true;
            this.btnCeiling.Click += new System.EventHandler(this.btnCeiling_Click);
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(25, 148);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(132, 28);
            this.btnRound.TabIndex = 4;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(25, 182);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(132, 28);
            this.btnMax.TabIndex = 5;
            this.btnMax.Text = "MAX";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(25, 216);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(132, 28);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "MIN";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnUst
            // 
            this.btnUst.Location = new System.Drawing.Point(245, 74);
            this.btnUst.Name = "btnUst";
            this.btnUst.Size = new System.Drawing.Size(212, 30);
            this.btnUst.TabIndex = 7;
            this.btnUst.Text = "button1";
            this.btnUst.UseVisualStyleBackColor = true;
            this.btnUst.Click += new System.EventHandler(this.btnUst_Click);
            // 
            // txtUst
            // 
            this.txtUst.Location = new System.Drawing.Point(245, 18);
            this.txtUst.Name = "txtUst";
            this.txtUst.Size = new System.Drawing.Size(212, 22);
            this.txtUst.TabIndex = 8;
            // 
            // txtTaban
            // 
            this.txtTaban.Location = new System.Drawing.Point(245, 46);
            this.txtTaban.Name = "txtTaban";
            this.txtTaban.Size = new System.Drawing.Size(212, 22);
            this.txtTaban.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(524, 417);
            this.Controls.Add(this.txtTaban);
            this.Controls.Add(this.txtUst);
            this.Controls.Add(this.btnUst);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.btnCeiling);
            this.Controls.Add(this.btnFloor);
            this.Controls.Add(this.btnMutlak);
            this.Controls.Add(this.btnPi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnMutlak;
        private System.Windows.Forms.Button btnFloor;
        private System.Windows.Forms.Button btnCeiling;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnUst;
        private System.Windows.Forms.TextBox txtUst;
        private System.Windows.Forms.TextBox txtTaban;
    }
}

