using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        Islemci islemci;
        double sonuc = 0;
        string opt;
        public Form1()
        {
            InitializeComponent();
            this.islemci = new Islemci();
        }
        private void Rakamlar(object sender, EventArgs e)
        {
            if (textBoxSonuc.Text == "0" || textBoxSonuc==null )
            {
                textBoxSonuc.Clear();
            }
            Button btn = (Button)sender;
            textBoxSonuc.Text += btn.Text;

        }
        double ilkSayı = 0;

        private void Hesap(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ilkSayı = Convert.ToDouble(textBoxSonuc.Text);
            textBoxSonuc.Text = null;
            opt = btn.Text;                     

        }
      
        private void button17_Click(object sender, EventArgs e)
        {
            double ikinciSayı = 0;
            double sonuc = 0;
            ikinciSayı = Convert.ToDouble(textBoxSonuc.Text);

            switch (opt)
            {
                case "+":
                    sonuc =this.islemci.toplama(ilkSayı, ikinciSayı);
                    textBoxSonuc.Text = Convert.ToString(sonuc);
                    ilkSayı = sonuc;
                    break;
                case "-":
                    sonuc = this.islemci.cikarma(ilkSayı, ikinciSayı);
                    textBoxSonuc.Text = Convert.ToString(sonuc);
                    ilkSayı = sonuc;
                    break;
                case "*":
                    sonuc = this.islemci.carpma(ilkSayı, ikinciSayı);
                    textBoxSonuc.Text = Convert.ToString(sonuc);
                    ilkSayı = sonuc;
                    break;
                case "/":
                    
                    try
                    {
                        sonuc = this.islemci.bölme(ilkSayı, ikinciSayı);
                        textBoxSonuc.Text = Convert.ToString(sonuc);
                        ilkSayı = sonuc;
                    }
                    catch (DivideByZeroException) {
                        textBoxSonuc.Text = "Payda Sıfır Olamaz!";
                        
                    }
                  
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxSonuc.Text = null;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxSonuc.Text = textBoxSonuc.Text + ",";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(textBoxSonuc.Text);
            textBoxSonuc.Text = Convert.ToString(sonuc / 100);
         }

        private void button2_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(textBoxSonuc.Text);
            textBoxSonuc.Text = Convert.ToString((-1) * sonuc);

        }
    }
}
