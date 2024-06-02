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
        public TextboxProccessClass(TextBox OgrenciAdi, TextBox OgrenciSoyadi, TextBox OgrenciNumarasi, TextBox OgrenciTelefonNumarasi)
        {
            _tbAd = OgrenciAdi;
            _tbSoyad = OgrenciSoyadi;
            _tbOgNo = OgrenciNumarasi;
            _tbTelNo = OgrenciTelefonNumarasi;
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
    }
}
