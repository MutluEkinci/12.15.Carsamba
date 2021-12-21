
namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.Sayı1 = new System.Windows.Forms.Label();
            this.Sayı2 = new System.Windows.Forms.Label();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.Sonuc = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstSayisal = new System.Windows.Forms.ListBox();
            this.btnSayisal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(270, 83);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(242, 22);
            this.txtSayi1.TabIndex = 1;
            // 
            // Sayı1
            // 
            this.Sayı1.AutoSize = true;
            this.Sayı1.Location = new System.Drawing.Point(187, 88);
            this.Sayı1.Name = "Sayı1";
            this.Sayı1.Size = new System.Drawing.Size(51, 17);
            this.Sayı1.TabIndex = 2;
            this.Sayı1.Text = "Sayı 1:";
            // 
            // Sayı2
            // 
            this.Sayı2.AutoSize = true;
            this.Sayı2.Location = new System.Drawing.Point(187, 127);
            this.Sayı2.Name = "Sayı2";
            this.Sayı2.Size = new System.Drawing.Size(51, 17);
            this.Sayı2.TabIndex = 3;
            this.Sayı2.Text = "Sayı 2:";
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(270, 122);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(242, 22);
            this.txtSayi2.TabIndex = 4;
            // 
            // Sonuc
            // 
            this.Sonuc.AutoSize = true;
            this.Sonuc.Location = new System.Drawing.Point(187, 161);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(48, 17);
            this.Sonuc.TabIndex = 5;
            this.Sonuc.Text = "Sonuc";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(270, 156);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(242, 22);
            this.txtSonuc.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(370, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(420, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(168, 278);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(393, 34);
            this.textBox1.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(270, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 95);
            this.button5.TabIndex = 11;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(168, 419);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 148);
            this.listBox1.TabIndex = 12;
            // 
            // lstSayisal
            // 
            this.lstSayisal.FormattingEnabled = true;
            this.lstSayisal.ItemHeight = 16;
            this.lstSayisal.Location = new System.Drawing.Point(849, 190);
            this.lstSayisal.Name = "lstSayisal";
            this.lstSayisal.Size = new System.Drawing.Size(284, 212);
            this.lstSayisal.TabIndex = 13;
            // 
            // btnSayisal
            // 
            this.btnSayisal.Location = new System.Drawing.Point(1013, 419);
            this.btnSayisal.Name = "btnSayisal";
            this.btnSayisal.Size = new System.Drawing.Size(120, 64);
            this.btnSayisal.TabIndex = 14;
            this.btnSayisal.Text = "Rakamlar";
            this.btnSayisal.UseVisualStyleBackColor = true;
            this.btnSayisal.Click += new System.EventHandler(this.btnSayisal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 587);
            this.Controls.Add(this.btnSayisal);
            this.Controls.Add(this.lstSayisal);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.Sayı2);
            this.Controls.Add(this.Sayı1);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Label Sayı1;
        private System.Windows.Forms.Label Sayı2;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lstSayisal;
        private System.Windows.Forms.Button btnSayisal;
    }
}

