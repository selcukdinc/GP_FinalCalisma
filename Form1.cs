using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string _conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ Application.StartupPath +"\\dbStudent.accdb";
        OleDbConnection conTest = new OleDbConnection(_conStr);

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
