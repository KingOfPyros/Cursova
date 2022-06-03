using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Cursova
{
    public partial class Form1 : Form
    {

        C_DataBase dataBase = new C_DataBase();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sign sign = new Sign();
            sign.Show();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataBase.openConnection();

            string querystring = $"SELECT * FROM Games";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

        }
    }
}
