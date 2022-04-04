namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtboxhuruf = new System.Windows.Forms.TextBox();
            this.txtboxmenjadi = new System.Windows.Forms.TextBox();
            this.lblhasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Masukkan Kalimat:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Masukkan Huruf:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menjadi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasil:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(592, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Konverensi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(157, 71);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(592, 26);
            this.txtname.TabIndex = 8;
            // 
            // txtboxhuruf
            // 
            this.txtboxhuruf.Location = new System.Drawing.Point(157, 130);
            this.txtboxhuruf.Name = "txtboxhuruf";
            this.txtboxhuruf.Size = new System.Drawing.Size(180, 26);
            this.txtboxhuruf.TabIndex = 9;
            this.txtboxhuruf.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtboxmenjadi
            // 
            this.txtboxmenjadi.Location = new System.Drawing.Point(454, 130);
            this.txtboxmenjadi.Name = "txtboxmenjadi";
            this.txtboxmenjadi.Size = new System.Drawing.Size(148, 26);
            this.txtboxmenjadi.TabIndex = 10;
            // 
            // lblhasil
            // 
            this.lblhasil.AutoSize = true;
            this.lblhasil.Location = new System.Drawing.Point(153, 303);
            this.lblhasil.Name = "lblhasil";
            this.lblhasil.Size = new System.Drawing.Size(0, 20);
            this.lblhasil.TabIndex = 11;
            this.lblhasil.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblhasil);
            this.Controls.Add(this.txtboxmenjadi);
            this.Controls.Add(this.txtboxhuruf);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtboxhuruf;
        private System.Windows.Forms.TextBox txtboxmenjadi;
        private System.Windows.Forms.Label lblhasil;
    }
}

