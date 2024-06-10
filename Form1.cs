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
using System.IO;
using System.Drawing.Drawing2D;

namespace FinalCalisma
{
    public partial class Form1 : Form
    {
        DataAccessClass dac;
        TextboxProccessClass tpc;
        static string _conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbVeritabani.accdb";
        int selectedIndex = -1;
        // tblOgr       tblManavUrun        tblSofor
        public Form1()
        {
            InitializeComponent();
            dac = new DataAccessClass(_conStr, dgvOgrenciler);
            tpc = new TextboxProccessClass(tbAd, tbSoyad, tbOgrNo, tbTelNo, tbAlis, tbStok, tbSatis, cbUrun, tbSoforIsim, tbSoforTelNo, cbHat1, cbHat2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pnlGeneral.Enabled = false;
            tcMain.SelectedTab = tpDataTable;
            dac.Read("tblOgr");
            dac.Read("tblManavUrun", dgvManav);
            dac.Read("tblSofor", dgvSofor);

            FileStream fsManav = new FileStream($"{Application.StartupPath}\\ManavUrunler.txt", FileMode.Open);
            StreamReader srManav = new StreamReader(fsManav);

            FileStream fsSoforHat = new FileStream($"{Application.StartupPath}\\iller.txt", FileMode.Open);
            StreamReader srSofor = new StreamReader(fsSoforHat);

            string kelime;
            while ((kelime = srManav.ReadLine()) != null)
                cbUrun.Items.Add(kelime);
            
            while ((kelime = srSofor.ReadLine()) != null)
            {
                cbHat1.Items.Add(kelime);
                cbHat2.Items.Add(kelime);
            }


        }


        #region Öğrenciler

        // tablo isimleri : tblOgr

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
            if (selectedIndex != -1)
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
            if (selectedIndex != -1)
            {
                if (MessageBox.Show("Silme işlemine devam Etmek istediğine emin misin?", "Silme İşlemi Gerçekleştiriliyor", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    dac.Delete("tblOgr", selectedIndex);
                    dac.Read("tblOgr");
                }
            }
        }

        #endregion

        #region Manav
        int selectedIndexManav = -1;

        private void dgvManav_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex != -1 && e.RowIndex < dgvManav.RowCount - 1)
            {
                selectedIndexManav = Convert.ToInt32(dgvManav.Rows[e.RowIndex].Cells[0].Value);
                cbUrun.Text = dgvManav.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbAlis.Text = dgvManav.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbStok.Text = dgvManav.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbSatis.Text = dgvManav.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnManavCreate_Click(object sender, EventArgs e)
        {
            if (tpc.CheckerManav())
            {
                dac.ManavCreate(cbUrun.Text, tbAlis, tbStok, tbSatis);
                dac.Read("tblManavUrun", dgvManav);
                tpc.CleanerManav();
            }
        }

        private void btnManavRead_Click(object sender, EventArgs e)
        {
            dac.Read("tblManavUrun", dgvManav);
        }

        private void btnManavUpdate_Click(object sender, EventArgs e)
        {
            if (tpc.CheckerManav())
            {
                dac.ManavUpdate(cbUrun.Text, tbAlis, tbStok, tbSatis, selectedIndexManav);
                dac.Read("tblManavUrun", dgvManav);
                tpc.CleanerManav();
            }
        }

        private void btnManavDelete_Click(object sender, EventArgs e)
        {
            if (selectedIndexManav != -1)
            {
                if (MessageBox.Show("Silme işlemine devam Etmek istediğine emin misin?", "Silme İşlemi Gerçekleştiriliyor", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    dac.Delete("tblManavUrun", selectedIndexManav);
                    dac.Read("tblManavUrun");
                }
            }
        }

        #endregion

        #region Şöförler

        private void btnSoforCreate_Click(object sender, EventArgs e)
        {
            if (tpc.CheckerSofor())
            {
                dac.SoforCreate(tbSoforIsim, tbSoforTelNo, $"{cbHat1.Text} - {cbHat2.Text}");
                dac.Read("tblSofor", dgvSofor);
                tpc.CleanerSofor();
            }
        }




        #endregion

        private void mtbMatrixN_KeyUp(object sender, KeyEventArgs e)
        {
            //Regex r1 = new Regex(@"^[0-9]+$");
            //Match m1 = r1.Match(mtbMatrixN.Text);
            //if (m1.Success)
            //    pnlGeneral.Enabled = true;
            //else
            //    pnlGeneral.Enabled = false;
        }

        private void cbHand_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHand.CheckState == CheckState.Checked)
                pnlRnd.Enabled = false;
            else
                pnlRnd.Enabled = true;
        }
        DataTable dt1 = new DataTable("Matris 1");
        DataTable dt2 = new DataTable("Matris 2");
        DataTable dtRes = new DataTable("Matris Result");
        private void btnRndGen_Click(object sender, EventArgs e)
        {
            Regex r1 = new Regex(@"^[0-9]+$");
            Match m1 = r1.Match(mtbMin.Text), m2 = r1.Match(mtbMax.Text);
            if (true) {
                
                Random R = new Random();
                int Max = Convert.ToInt32(mtbMax.Text);
                int Min = Convert.ToInt32(mtbMin.Text);
                for (int i = 0; i < 3; i++)
                {
                    
                    DataColumn dc1 = new DataColumn()
                    {
                        ColumnName = $"M1-{i+1}",
                        MaxLength = 50,  
                    };
                    DataColumn dc2 = new DataColumn()
                    {
                        ColumnName = $"M2-{i + 1}",
                        MaxLength = 5,
                    };
                    dt1.Columns.Add(dc1);
                    dt2.Columns.Add(dc2);
                }
                for (int i = 0; i < 3; i++)
                {
                    
                    dt1.Rows.Add(R.Next(Min,Max + 1), R.Next(Min, Max + 1) , R.Next(Min, Max + 1));
                    dt2.Rows.Add(R.Next(Min, Max + 1), R.Next(Min, Max + 1), R.Next(Min, Max + 1));
                }
                dgvMatrix1.DataSource = dt1;
                dgvMatrix2.DataSource = dt2;
                for (int i = 0; i < 3; i++)
                {
                    dgvMatrix1.Columns[i].Width = 30;
                    dgvMatrix2.Columns[i].Width = 30;
                }
                
            }
            else { }
                
            
            
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if(cbOperators.SelectedIndex != -1)
            {
                /*
                    Topla
                    Çıkar
                    Böl
                    Çarp
                 */
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        DataColumn dcRes = new DataColumn()
                        {
                            ColumnName = $"MR-{i + 1}",
                            MaxLength = 50,
                        };
                        dtRes.Columns.Add(dcRes);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        dtRes.Rows.Add(0, 0, 0);
                    }
                }
                catch
                {

                }
                

                switch (cbOperators.SelectedIndex)
                {
                    case 0:
                        for (int i = 0; i < 3; i++)
                        {
                            object[] temp = new object[3];
                            for (int j = 0; j < 3; j++)
                            {
                                int matrix1 = Convert.ToInt32(dt1.Rows[i].ItemArray[j]);
                                int matrix2 = Convert.ToInt32(dt2.Rows[i].ItemArray[j]);
                                //MessageBox.Show($"{matrix1}+{matrix2} = {matrix1+matrix2}");
                                temp[j] = matrix1 + matrix2;
                            }
                            dtRes.Rows[i].ItemArray = temp;
                        }
                        break;
                    case 1:
                        for (int i = 0; i < 3; i++)
                        {
                            object[] temp = new object[3];
                            for (int j = 0; j < 3; j++)
                            {
                                int matrix1 = Convert.ToInt32(dt1.Rows[i].ItemArray[j]);
                                int matrix2 = Convert.ToInt32(dt2.Rows[i].ItemArray[j]);
                                //MessageBox.Show($"{matrix1}+{matrix2} = {matrix1+matrix2}");
                                temp[j] = matrix1 - matrix2;
                            }
                            dtRes.Rows[i].ItemArray = temp;
                        }
                        break;
                    case 2:
                        for (int i = 0; i < 3; i++)
                        {
                            object[] temp = new object[3];
                            for (int j = 0; j < 3; j++)
                            {
                                int matrix1 = Convert.ToInt32(dt1.Rows[i].ItemArray[j]);
                                int matrix2 = Convert.ToInt32(dt2.Rows[i].ItemArray[j]);
                                //MessageBox.Show($"{matrix1}+{matrix2} = {matrix1+matrix2}");
                                try
                                {
                                    temp[j] = (double)matrix1 / matrix2;
                                }
                                catch
                                {
                                }
                            }
                            dtRes.Rows[i].ItemArray = temp;
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 3; i++)
                        {
                            object[] temp = new object[3];
                            for (int j = 0; j < 3; j++)
                            {
                                int matrix1 = Convert.ToInt32(dt1.Rows[i].ItemArray[j]);
                                int matrix2 = Convert.ToInt32(dt2.Rows[i].ItemArray[j]);
                                //MessageBox.Show($"{matrix1}+{matrix2} = {matrix1+matrix2}");
                                temp[j] = matrix1 * matrix2;
                            }
                            dtRes.Rows[i].ItemArray = temp;
                        }
                        break;

                }
                dgvMatrixResult.DataSource = dtRes;
                for (int i = 0; i < 3; i++)
                {
                    dgvMatrixResult.Columns[i].Width = 30;
                }
            }
        }
    }
}
