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

    }
}
