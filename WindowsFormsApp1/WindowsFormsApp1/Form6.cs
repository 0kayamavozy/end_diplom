using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string sqlConnection = $@"Data Source={Global.HostServer};Initial Catalog=TrainDataBase;Integrated Security=True";
            SqlConnection connection = new SqlConnection(sqlConnection);
            string query = "select * from TrainInfo";

            connection.Open();

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                guna2DataGridView2.DataSource = dt;
            }

            connection.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
