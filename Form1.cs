using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HESAPMAKINESII
{
    public partial class Form1 : Form
    {
        private char _islem;
        bool _ekrantemizlenecekmi;
        int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            { 
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
           
            if(ekranlabel.Text=="0") ekranlabel.Text="";
            ekranlabel.Text += "1";

        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void artibutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);

        }

        private void esittirbutton_Click(object sender, EventArgs e)
        {
            int ikinciSayi=Convert.ToInt32(ekranlabel.Text);
            int sonuc;
            switch(_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikinciSayi;
                    break;
                case 'X':
                    sonuc = _ilksayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikinciSayi;
                    break;
                    default: sonuc = 0; break;
            }
            ekranlabel.Text=Convert.ToString(sonuc);
        }

        private void eksibuuttton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void xbutton_Click(object sender, EventArgs e)
        {
            _islem = 'X';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void bolubutton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void temizlemebutton_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }
    }
}
