using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {

        private char _islem;
        private bool _ekrantemizleme;
        private int _ilksayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;
            }
            if (_ekrantemizleme) ekranLabel.Text = "";
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;
            }
            if (_ekrantemizleme) ekranLabel.Text = "";
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;
            }
            if (_ekrantemizleme) ekranLabel.Text = "";
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;
            }
            if (_ekrantemizleme) ekranLabel.Text = "";
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;
            }
            if (_ekrantemizleme) ekranLabel.Text = "";
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;
            }
            if (_ekrantemizleme) ekranLabel.Text = "";
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;
            }
            if (_ekrantemizleme) ekranLabel.Text = "";
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
           if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranLabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void artiButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizleme = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void esitButton_Click(object sender, EventArgs e)
        {
            int _ikincisayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + _ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - _ikincisayi;
                    break;
                case 'x':
                    sonuc = _ilksayi * _ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / _ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;  
            
            }
                ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizleme = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpıButton_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _ekrantemizleme = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void boluButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizleme = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }

        private void ekranLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
