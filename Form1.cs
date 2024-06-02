using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCalisma
{
    public partial class Form1 : Form
    {
        DataAccessClass dac;
        TextboxProccessClass tpc;
        static string _conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbStudent.accdb";
        int selectedIndex = -1;

        public Form1()
        {
            InitializeComponent();
            dac = new DataAccessClass(_conStr, dgvOgrenciler);
            tpc = new TextboxProccessClass(tbAd, tbSoyad, tbOgrNo, tbTelNo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dac.Read("tblOgr");
        }

        private void dgvOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1 && e.RowIndex < dgvOgrenciler.RowCount - 1)
            {
                selectedIndex = Convert.ToInt32(dgvOgrenciler.Rows[e.RowIndex].Cells[0].Value);
                tbAd.Text = (string)dgvOgrenciler.Rows[e.RowIndex].Cells[1].Value;
                tbSoyad.Text = (string)dgvOgrenciler.Rows[e.RowIndex].Cells[2].Value;
                tbOgrNo.Text = (string)dgvOgrenciler.Rows[e.RowIndex].Cells[3].Value;
                tbTelNo.Text = (string)dgvOgrenciler.Rows[e.RowIndex].Cells[4].Value;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tpc.Cleaner();
        }


        // tablo isimleri : tblOgr

        // C R U D işlemleri

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (tpc.Checker())
            {
                dac.Create(tbAd, tbSoyad, tbOgrNo, tbTelNo);
                dac.Read("tblOgr");
                tpc.Cleaner();
            }
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            dac.Read("tblOgr");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(selectedIndex != -1)
            {
                if (tpc.Checker())
                {
                    dac.Update(tbAd, tbSoyad, tbOgrNo, tbTelNo, "tblOgr", selectedIndex);
                    dac.Read("tblOgr");
                    tpc.Cleaner();
                }
            }    
            else
                MessageBox.Show("Satır seçin");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedIndex != -1)
            {
                if (MessageBox.Show("Silme işlemine devam Etmek istediğine emin misin?", "Silme İşlemi Gerçekleştiriliyor", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    dac.Delete("tblOgr", selectedIndex);
                    dac.Read("tblOgr");
                }
            }
            
        }
    }
}
