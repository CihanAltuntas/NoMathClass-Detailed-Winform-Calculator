using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form

       // private string oncekiDeger = "";
    {
        Matematik matematik = new Matematik();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text=matematik.Mutlak(int.Parse(textBox1.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text=matematik.Karekok(int.Parse(textBox1.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] metin = textBox1.Text.Split(',');
            int[] sayilar = new int[metin.Length];
            for(int i = 0; i < metin.Length; i++)
            {
                sayilar[i] = int.Parse(metin[i]);
            }

            textBox1.Text=matematik.MaxBulma(sayilar).ToString();
        }
    }
}
