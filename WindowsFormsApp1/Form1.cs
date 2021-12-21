using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = Convert.ToString(int.Parse(txtSayi1.Text) + int.Parse(txtSayi2.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = Convert.ToString(int.Parse(txtSayi1.Text) - int.Parse(txtSayi2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = Convert.ToString(int.Parse(txtSayi1.Text) / int.Parse(txtSayi2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = Convert.ToString(int.Parse(txtSayi1.Text) * int.Parse(txtSayi2.Text));
        }



        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnSayisal_Click(object sender, EventArgs e)
        {
            lstSayisal.Items.Clear();

            Random rnd = new Random();
            while (true)
            {
                int sayi = rnd.Next(1, 50);

                if (!(lstSayisal.Items.Contains(sayi)))
                    lstSayisal.Items.Add(sayi);
                if (lstSayisal.Items.Count == 6)
                    break;
            }


            
            
        }
    }
}
