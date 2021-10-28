using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiErdem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi = 0; // ikinci girilen sayımız 
        double sonuc = 0;   //islemin sonucu.
        double ilk = 0; // ilk girilen sayımız.
        string islem = "";  //islem sonucumuz


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Clear();
            }

            textBox1.Text = textBox1.Text + "8";
            sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Clear();
            }
            //yukarıda rakam yerine herhangi bir islem girdisi olmasın diye sorgulama yaptırdık
            textBox1.Text = textBox1.Text + "7";
            sayi = Convert.ToDouble(textBox1.Text); //girilen islemin sonucunu dogru vermesi icin stringi double cevirdik.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "+";
            islem = "+";
            ilk = sayi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Clear();
            }

            textBox1.Text = textBox1.Text + "9";
            sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Clear();
            }

            textBox1.Text = textBox1.Text + "4";
            sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Clear();
            }

            textBox1.Text = textBox1.Text + "5";
            sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Clear();
            }

            textBox1.Text = textBox1.Text + "6";
            sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Clear();
            }

            textBox1.Text = textBox1.Text + "1";
            sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Clear();
            }

            textBox1.Text = textBox1.Text + "2";
            sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Clear();
            }

            textBox1.Text = textBox1.Text + "3";
            sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Clear();
            }

            textBox1.Text = textBox1.Text + "0";
            sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-";
            islem = "-";
            ilk = sayi;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "*";
            islem = "*";
            ilk = sayi;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/";
            islem = "/";
            ilk = sayi;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {
                sonuc = ilk + sayi;
                textBox1.Text = sonuc.ToString();
                sayi = sonuc;
            }

            if (islem == "-")
            {
                sonuc = ilk - sayi;
                textBox1.Text = sonuc.ToString();
                sayi = sonuc;
            }

            if (islem == "*")
            {
                sonuc = ilk * sayi;
                textBox1.Text = sonuc.ToString();
                sayi = sonuc;

            }

            if (islem == "/")
            {
                sonuc = ilk / sayi;
                textBox1.Text = sonuc.ToString();
                sayi = sonuc;
            }
            if(islem == "%")
            {
                sayi = Convert.ToDouble(textBox1.Text);
                sonuc = ilk * sayi / 100;
                textBox1.Text = sonuc.ToString();
            }
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ilk = Convert.ToDouble(textBox1.Text);
            islem = "%";
            textBox1.Text = "";


        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            ilk = Convert.ToDouble(textBox1.Text);
            sonuc = ilk * ilk;
            textBox1.Text = sonuc.ToString();
            

        }

        private void button19_Click(object sender, EventArgs e)
        {
            ilk = Convert.ToDouble(textBox1.Text);
            sonuc = Math.Sqrt(ilk);
            textBox1.Text = sonuc.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ilk = Convert.ToDouble(textBox1.Text);
            sonuc = ilk / 2;
            textBox1.Text = sonuc.ToString();
        }
    }
}
