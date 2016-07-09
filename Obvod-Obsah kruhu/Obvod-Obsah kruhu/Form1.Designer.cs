namespace Obvod_Obsah_kruhu
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
            this.txtObvod = new System.Windows.Forms.TextBox();
            this.txtObsah = new System.Windows.Forms.TextBox();
            this.txtPolomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPremena = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtObvod
            // 
            this.txtObvod.Location = new System.Drawing.Point(10, 56);
            this.txtObvod.Name = "txtObvod";
            this.txtObvod.Size = new System.Drawing.Size(100, 22);
            this.txtObvod.TabIndex = 0;
            // 
            // txtObsah
            // 
            this.txtObsah.Location = new System.Drawing.Point(203, 56);
            this.txtObsah.Name = "txtObsah";
            this.txtObsah.Size = new System.Drawing.Size(100, 22);
            this.txtObsah.TabIndex = 1;
            // 
            // txtPolomer
            // 
            this.txtPolomer.Location = new System.Drawing.Point(108, 28);
            this.txtPolomer.Name = "txtPolomer";
            this.txtPolomer.Size = new System.Drawing.Size(100, 22);
            this.txtPolomer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Polomer kruhu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Obvod kruhu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Obsah kruhu";
            // 
            // btnPremena
            // 
            this.btnPremena.Location = new System.Drawing.Point(120, 56);
            this.btnPremena.Name = "btnPremena";
            this.btnPremena.Size = new System.Drawing.Size(75, 23);
            this.btnPremena.TabIndex = 6;
            this.btnPremena.Text = "Premeniť";
            this.btnPremena.UseVisualStyleBackColor = true;
            this.btnPremena.Click += new System.EventHandler(this.btnPremena_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jednotky sú cm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 113);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPremena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPolomer);
            this.Controls.Add(this.txtObsah);
            this.Controls.Add(this.txtObvod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Obvod-Obsah kruhu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtObvod;
        private System.Windows.Forms.TextBox txtObsah;
        private System.Windows.Forms.TextBox txtPolomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPremena;
        private System.Windows.Forms.Label label4;
    }
}

