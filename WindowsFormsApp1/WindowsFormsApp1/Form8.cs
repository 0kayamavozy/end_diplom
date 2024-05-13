using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Global.HostServer = guna2ComboBox1.Text;
            if (guna2CheckBox1.Checked)
            {
                File.WriteAllText(Environment.CurrentDirectory + @"\Log\Server.txt", guna2ComboBox1.Text);
                File.WriteAllText(Environment.CurrentDirectory + @"\Log\SaveServer.txt", "1");
                guna2CheckBox1.Checked = false;
            }
            else if (!guna2CheckBox1.Checked)
            {
                File.WriteAllText(Environment.CurrentDirectory + @"\Log\Server.txt", string.Empty);
                File.WriteAllText(Environment.CurrentDirectory + @"\Log\SaveServer.txt", "0");
            }

            label5.Text = guna2ComboBox1.Text;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            InsertServer();
        }

        private void InsertServer()
        {
            string sqlconnection = $@"Data Source={Global.HostServer};Initial Catalog=TrainDataBase;Integrated Security=True";
            SqlConnection connection = new SqlConnection(sqlconnection);
            string query = "insert into Servers(ServerName) values(@ServerName)";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ServerName", guna2TextBox1.Text);

            command.ExecuteNonQuery();

            connection.Close();
        }

        private string Connection()
        {
            return $@"Data Source=(localdb)\Mssqllocaldb;Initial Catalog=TrainDataBase;Integrated Security=True";
        }

        public void loadElementToCombobox(string stringQuery, string column, Guna2ComboBox comboBox)
        {
            List<string> ColumnValues = GetColumnValues(stringQuery, column);
            comboBox.Items.AddRange(ColumnValues.ToArray());
        }

        public List<string> GetColumnValues(string query, string ColumnName)
        {
            List<string> columnValues = new List<string>();

            SqlConnection connection = new SqlConnection(Connection());
            connection.Open();
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object columnValueObject = reader.GetValue(reader.GetOrdinal(ColumnName));
                    string columnValue = columnValueObject != DBNull.Value ? columnValueObject.ToString() : "";
                    columnValues.Add(columnValue);
                }
            }

            return columnValues;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label5.Text = Global.HostServer;

            string query = "Select * from Servers";
            loadElementToCombobox(query, "ServerName", guna2ComboBox1);
        }
    }
}
