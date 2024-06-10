using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCalisma
{
    internal class TextboxProccessClass
    {
        private TextBox _tbAd, _tbSoyad, _tbOgNo, _tbTelNo;

        private TextBox _tbAlis, _tbStok, _tbSatis;
        private ComboBox _cbManav;

        private TextBox _tbSoforAd, _tbSoforTelNo;
        ComboBox _cbHat1, _cbHat2;
        public TextboxProccessClass(TextBox OgrenciAdi, TextBox OgrenciSoyadi, TextBox OgrenciNumarasi, TextBox OgrenciTelefonNumarasi, TextBox Alis, TextBox Stok, TextBox Satis, ComboBox ManavUrun, TextBox SoforAd, TextBox SoforTelNo, ComboBox cbHat1, ComboBox cbHat2)
        {
            _tbAd = OgrenciAdi;
            _tbSoyad = OgrenciSoyadi;
            _tbOgNo = OgrenciNumarasi;
            _tbTelNo = OgrenciTelefonNumarasi;
            _tbAlis = Alis;
            _tbStok = Stok;
            _tbSatis = Satis;
            _cbManav = ManavUrun;
            _tbSoforAd = SoforAd;
            _tbSoforTelNo = SoforTelNo;
            _cbHat1 = cbHat1;
            _cbHat2 = cbHat2;
        }

        public bool Checker()
        {
            Regex r1 = new Regex(@"^[A-Z Ş Ö Ç Ü İ][a-z ç ö ş ı ü ğ]+$"); // İsim Kontrolü
            Regex r2 = new Regex(@"^[A-Z Ş Ö Ç Ü İ Ğ]+$"); // Soyadı kontrolü
            Regex r3 = new Regex(@"^[0-9]{9}$"); // Öğrenci No kontrol ifadesi
            Regex r4 = new Regex(@"^[1-9][0-9]{9}$"); // Tel No kontrol ifadesi

            Match m1 = r1.Match(_tbAd.Text), m2 = r2.Match(_tbSoyad.Text), m3 = r3.Match(_tbOgNo.Text), m4 = r4.Match(_tbTelNo.Text);

            if (m1.Success && m2.Success && m3.Success && m4.Success)
                return true;
            else if (!m1.Success)
                MessageBox.Show("İsminizi yanlış girdiniz");
            else if (!m2.Success)
                MessageBox.Show("Soyadınızı yanlış girdiniz");
            else if (!m3.Success)
                MessageBox.Show("Öğrenci numamranızı yanlış girdiniz");
            else
                MessageBox.Show("Telefon numaranızı yanlış girdiniz");
            return false;
        }

        public void Cleaner()
        {
            _tbAd.Text = string.Empty;
            _tbSoyad.Text = string.Empty;
            _tbOgNo.Text = string.Empty;
            _tbTelNo.Text = string.Empty;
        }

        // Manav Panel işlemleri

        public bool CheckerManav()
        {
            Regex r1 = new Regex(@"^[0-9]+$"); // Stok textbox kontrolü
            Match m1 = r1.Match(_tbAlis.Text), m2 = r1.Match(_tbStok.Text), m3 = r1.Match(_tbSatis.Text);
            if (m1.Success && m2.Success && m3.Success && _cbManav.Text != string.Empty)
                return true;
            else if(!m1.Success)
                MessageBox.Show("Alış fiyatını sadece rakamlarda oluşacak şekilde girin");
            else if (!m2.Success)
                MessageBox.Show("Stok adedini sadece rakamlarda oluşacak şekilde girin");
            else if (!m3.Success)
                MessageBox.Show("Satış fiyatını sadece rakamlarda oluşacak şekilde girin");
            else if (_cbManav.Text == string.Empty)
                MessageBox.Show("Ürün seçimi boş bırakılamaz");
            return false;
        }

        public void CleanerManav()
        {
            _tbAlis.Text = string.Empty;
            _tbStok.Text = string.Empty;
            _tbSatis.Text = string.Empty;
            _cbManav.SelectedIndex = -1;
        }


        // Şöför Panel İşlemleri

        public bool CheckerSofor()
        {
            Regex r1 = new Regex(@"^[A-Z Ş Ö Ç Ü İ][a-z ç ö ş ı ü ğ]+$"); // İsim Kontrolü
            Regex r2 = new Regex(@"^[1-9][0-9]{9}$"); // Tel No kontrol ifadesi
            Match m1 = r1.Match(_tbSoforAd.Text), m2 = r2.Match(_tbSoforTelNo.Text);
            if (m1.Success && m2.Success && (_cbHat1.Text != _cbHat2.Text))
                return true;
            else if(!m1.Success)
                MessageBox.Show("İsminizi yanlış girdiniz");
            else if(!m2.Success)
                MessageBox.Show("Telefon numaranızı yanlış girdiniz");
            else if (_cbHat1.Text == _cbHat2.Text)
                MessageBox.Show("İki hat aynı olamaz");
            return false;
        }

        public void CleanerSofor()
        {
            _tbSoforAd.Text = string.Empty;
            _tbSoforTelNo.Text = string.Empty;
            _cbHat1.SelectedIndex = -1;
            _cbHat2.SelectedIndex = -1;
        }
    }
}
