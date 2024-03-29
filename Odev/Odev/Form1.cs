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
    public partial class Form1 : Form{
        
        public string oncekiDeger = "";

        Pen pen = new Pen(Color.Blue, 2.0f);

        List<PointF> sinNoktalari = new List<PointF>();

        List<PointF> cosNoktalari = new List<PointF>();  

        Matematik matematik = new Matematik();
        public Form1()
        {
            InitializeComponent();
        }

        private double SinHesapla(int aci)
        {
            double radyan=matematik.RadyanaCevir(aci);
            return matematik.Sin(radyan);
        }
        private double CosHesapla(int aci)
        {
            double radyan = matematik.RadyanaCevir(aci);
            return matematik.Cos(radyan);
        }
        private void noktalariHesapla(int baslangic,int bitis)
        {
            for (int i = baslangic; i < bitis; i++)
            {
                float sinNoktalariY = (float)SinHesapla(i) * (-1);
                float cosNoktalariY = (float)CosHesapla(i) * (-1);


                float sinNoktalariYukseklik = pictureBox1.Height / 2;
                float cosNoktalariYukseklik = pictureBox1.Height / 2;

                sinNoktalari.Add(new PointF(i, sinNoktalariY * sinNoktalariYukseklik + sinNoktalariYukseklik));
                cosNoktalari.Add(new PointF(i, cosNoktalariY * cosNoktalariYukseklik + cosNoktalariYukseklik));
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            noktalariHesapla(int.Parse(textBox2.Text),int.Parse(textBox3.Text));
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            if (radioButton1.Checked)
            {
                if (sinNoktalari.Count > 0)
                {
                    e.Graphics.DrawCurve(pen, sinNoktalari.ToArray());
                }
            }
            else if (radioButton2.Checked)
            {
                if (cosNoktalari.Count > 0)
                {
                    e.Graphics.DrawCurve(pen, cosNoktalari.ToArray());
                }
            }
        }









        private void button4_Click(object sender, EventArgs e)
        {
            oncekiDeger = textBox1.Text;
            double sinRadyan = int.Parse(textBox1.Text)* 3.14 / 180;
            textBox1.Text= matematik.Sin(sinRadyan).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oncekiDeger = textBox1.Text;
            double cosRadyan = int.Parse(textBox1.Text) * 3.14 / 180;
            textBox1.Text = matematik.Cos(cosRadyan).ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = oncekiDeger;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oncekiDeger = textBox1.Text;
            textBox1.Text=matematik.Mutlak(int.Parse(textBox1.Text)).ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oncekiDeger = textBox1.Text;
            textBox1.Text=matematik.Karekok(int.Parse(textBox1.Text)).ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oncekiDeger = textBox1.Text;
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
