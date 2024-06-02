using System;
using System.Collections.Generic;
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

        //public void Read(string tableName)
        //{
        //    using(OleDbConnection con = new OleDbConnection(_connecitonString))
        //    using (OleDbCommand cmd = new OleDbCommand())
        //    {
        //        cmd.Connection = con;
        //        cmd.CommandText = "SELECT * FROM (P1)";
        //        cmd.Parameters.Add("@P1", OleDbType.VarChar).Value = 

                
        //    }
        //}

    }
}
