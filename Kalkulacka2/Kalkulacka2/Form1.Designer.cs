namespace Kalkulacka2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnm = new System.Windows.Forms.Button();
            this.bntp = new System.Windows.Forms.Button();
            this.btnk = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.txtvysledok = new System.Windows.Forms.TextBox();
            this.txtcislo1 = new System.Windows.Forms.TextBox();
            this.txtcislo2 = new System.Windows.Forms.TextBox();
            this.txtcislo3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnm
            // 
            this.btnm.Location = new System.Drawing.Point(31, 383);
            this.btnm.Name = "btnm";
            this.btnm.Size = new System.Drawing.Size(115, 58);
            this.btnm.TabIndex = 0;
            this.btnm.Text = "-";
            this.btnm.UseVisualStyleBackColor = true;
            this.btnm.Click += new System.EventHandler(this.btnm_Click);
            // 
            // bntp
            // 
            this.bntp.Location = new System.Drawing.Point(31, 273);
            this.bntp.Name = "bntp";
            this.bntp.Size = new System.Drawing.Size(115, 58);
            this.bntp.TabIndex = 1;
            this.bntp.Text = "+";
            this.bntp.UseVisualStyleBackColor = true;
            this.bntp.Click += new System.EventHandler(this.bntp_Click);
            // 
            // btnk
            // 
            this.btnk.Location = new System.Drawing.Point(31, 495);
            this.btnk.Name = "btnk";
            this.btnk.Size = new System.Drawing.Size(112, 58);
            this.btnk.TabIndex = 2;
            this.btnk.Text = "*";
            this.btnk.UseVisualStyleBackColor = true;
            this.btnk.Click += new System.EventHandler(this.btnk_Click);
            // 
            // btnd
            // 
            this.btnd.Location = new System.Drawing.Point(28, 599);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(115, 58);
            this.btnd.TabIndex = 3;
            this.btnd.Text = ":";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // txtvysledok
            // 
            this.txtvysledok.Location = new System.Drawing.Point(12, 197);
            this.txtvysledok.Name = "txtvysledok";
            this.txtvysledok.Size = new System.Drawing.Size(147, 22);
            this.txtvysledok.TabIndex = 4;
            // 
            // txtcislo1
            // 
            this.txtcislo1.Location = new System.Drawing.Point(31, 31);
            this.txtcislo1.Name = "txtcislo1";
            this.txtcislo1.Size = new System.Drawing.Size(100, 22);
            this.txtcislo1.TabIndex = 5;
            // 
            // txtcislo2
            // 
            this.txtcislo2.Location = new System.Drawing.Point(31, 83);
            this.txtcislo2.Name = "txtcislo2";
            this.txtcislo2.Size = new System.Drawing.Size(100, 22);
            this.txtcislo2.TabIndex = 6;
            // 
            // txtcislo3
            // 
            this.txtcislo3.Location = new System.Drawing.Point(31, 134);
            this.txtcislo3.Name = "txtcislo3";
            this.txtcislo3.Size = new System.Drawing.Size(100, 22);
            this.txtcislo3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Delenie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Násobenie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pri násobení bez 3. čisla je porteba zmenit na 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 677);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Delenie funguje bez 3. čísla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mínus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Plus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Číslo 1.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Číslo 2.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Číslo 3.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Výsledok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 780);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcislo3);
            this.Controls.Add(this.txtcislo2);
            this.Controls.Add(this.txtcislo1);
            this.Controls.Add(this.txtvysledok);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnk);
            this.Controls.Add(this.bntp);
            this.Controls.Add(this.btnm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kalkulačka BlackReer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnm;
        private System.Windows.Forms.Button bntp;
        private System.Windows.Forms.Button btnk;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.TextBox txtvysledok;
        private System.Windows.Forms.TextBox txtcislo1;
        private System.Windows.Forms.TextBox txtcislo2;
        private System.Windows.Forms.TextBox txtcislo3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

