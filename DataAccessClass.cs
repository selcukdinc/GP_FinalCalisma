using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCalisma
{
    internal class DataAccessClass
    {

        private static string _connecitonString;
        DataGridView dgv;


        public DataAccessClass(string connectionString, DataGridView ActiveDataGridView)
        {
            _connecitonString = connectionString;
            dgv = ActiveDataGridView;
        }


        // -- Tablo ismi --
        //          tblOgr
        //  -- veritabanı sütunları --
        // Ad   Soyad   OgrNo   TelNo


        // Create - Yeni öğrenci kaydı oluşturma işlemi
        public void Create(TextBox tbAd, TextBox tbSoyad, TextBox tbOgrNo, TextBox tbTelNo)
        {
            using(OleDbConnection con = new OleDbConnection(_connecitonString))
            using (OleDbCommand cmd = new OleDbCommand())
            {
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO tblOgr (Ad, Soyad, OgrNo, TelNo) VALUES (P1,P2,P3,P4)";
                cmd.Parameters.Add("@P1", OleDbType.VarChar).Value = tbAd.Text;
                cmd.Parameters.Add("@P2", OleDbType.VarChar).Value = tbSoyad.Text;
                cmd.Parameters.Add("@P3", OleDbType.VarChar).Value = tbOgrNo.Text;
                cmd.Parameters.Add("@P4", OleDbType.VarChar).Value = tbTelNo.Text;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // constructor ile varsayılan bir dgv alınmıştır, read ile direkt dgv üstünde okuma işlemi yapılabilir,
        // Read - Okuma işlemi
        public void Read(string tableName)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(_connecitonString))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM " + tableName;
                    
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    
                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Farklı bir dgv için işlem yapılmak istendiğinde overload yapılmış read metodu
        public void Read(string tableName, DataGridView _dgv)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(_connecitonString))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM " + tableName;

                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    
                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    
                    _dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Update - Varolan veriyi güncelleme işlemi
        public void Update(TextBox tbAd, TextBox tbSoyad, TextBox tbOgrNo, TextBox tbTelNo, string tableName, int id)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(_connecitonString))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    //UPDATE tblOgr SET ad = 'Seko' , Soyad = 'Piko' , OgrNo = '2222' , TelNo = 'Bruh'  where ID = 2"

                    cmd.CommandText = String.Format("UPDATE {0} SET ad = P1 , Soyad = P2 , OgrNo = P3 , TelNo = P4  where ID = {1}", tableName, id);

                    cmd.Parameters.Add("@P1", OleDbType.VarChar).Value = tbAd.Text;
                    cmd.Parameters.Add("@P2", OleDbType.VarChar).Value = tbSoyad.Text;
                    cmd.Parameters.Add("@P3", OleDbType.VarChar).Value = tbOgrNo.Text;
                    cmd.Parameters.Add("@P4", OleDbType.VarChar).Value = tbTelNo.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Delete - Varolan veriyi silme işlemi
        public void Delete(string tableName, int id)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(_connecitonString))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    //DELETE * from  tblOgr where ID = 3

                    cmd.CommandText = String.Format("DELETE * from  {0} where ID = {1}", tableName, id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
