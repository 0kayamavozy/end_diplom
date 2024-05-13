using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }
        Point WindowPos;
        private void Move1(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                WindowPos = MousePosition;
        }

        private void Move2(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int PosX = MousePosition.X - WindowPos.X;
                int PosY = MousePosition.Y - WindowPos.Y;
                Point Loc = new Point(Location.X + PosX, Location.Y + PosY);
                Location = Loc;
                WindowPos = MousePosition;
            }
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.Red;
            guna2Button1.ForeColor = Color.White;
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.LightGray;
            guna2Button1.ForeColor= Color.Red;
        }

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Move1(e);
        }

        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Move2(e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string sqlConnection = $@"Data Source={Global.HostServer};Initial Catalog=TrainDataBase;Integrated Security=True";
            using (SqlConnection sqlcon = new SqlConnection(sqlConnection))
            {
                sqlcon.Open();

                SqlCommand sqlCommand = new SqlCommand("insert into TrainInfo(Otkyda, Kyda, Date, Departure, Arrival, Cost1, Count1, Cost2, Count2, Cost3, Count3, DateFrom, DateWhere, TrainID) " +
                    "values (@from, @To, @Date, @TimeFrom, @TimeTo, @CostPl, @CountPl, @CostCu, @CountCu, @CostCv, @CountCv, @DateFrom, @DateTo, @TrainNumber)", sqlcon);

                sqlCommand.Parameters.AddWithValue("@TrainNumber", TrainNumber.Text); // номер поезда

                sqlCommand.Parameters.AddWithValue("@from", _Form.Text); // откуда
                sqlCommand.Parameters.AddWithValue("@To", _To.Text); // куда
                
                
                sqlCommand.Parameters.AddWithValue("@Date", Convert.ToDateTime(_Date.Text)); // дата отправления

                sqlCommand.Parameters.AddWithValue("@TimeFrom", _TimeFrom.Text); // время отправления
                sqlCommand.Parameters.AddWithValue("@TimeTo", _TimeTo.Text); // время прибытия 

                sqlCommand.Parameters.AddWithValue("@DateFrom", Convert.ToDateTime(_DateFrom.Text)); // дата отправления
                sqlCommand.Parameters.AddWithValue("@DateTo", Convert.ToDateTime(_DateTo.Text)); // дата прибытия 

                sqlCommand.Parameters.AddWithValue("@CostPl", Convert.ToInt32(_CostPl.Text)); // цена за плацкарт
                sqlCommand.Parameters.AddWithValue("@CountPl", Convert.ToInt32(_CountPl.Text)); // количество мест

                sqlCommand.Parameters.AddWithValue("@CostCu", Convert.ToInt32(_CostCu.Text)); // цена за купе
                sqlCommand.Parameters.AddWithValue("@CountCu", Convert.ToInt32(_CountCu.Text)); // количество мест

                sqlCommand.Parameters.AddWithValue("@CostCv", Convert.ToInt32(_CostCV.Text)); // цена СВ
                sqlCommand.Parameters.AddWithValue("@CountCv", Convert.ToInt32(_CountCV.Text)); // количество мест

                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
            }


            using (SqlConnection sqlcon = new SqlConnection(sqlConnection))
            {
                sqlcon.Open();

                SqlCommand sqlCommand = new SqlCommand("insert into TrainStations values( @Main, @St2, @St3, @St4, @St5, @St6, @St7, @St8, @End)", sqlcon);

                sqlCommand.Parameters.AddWithValue("@Main", _Main.Text);
                sqlCommand.Parameters.AddWithValue("@St2", Station2.Text);
                sqlCommand.Parameters.AddWithValue("@St3", Station3.Text);
                sqlCommand.Parameters.AddWithValue("@St4", Station4.Text);
                sqlCommand.Parameters.AddWithValue("@St5", Station5.Text);
                sqlCommand.Parameters.AddWithValue("@St6", Station6.Text);
                sqlCommand.Parameters.AddWithValue("@St7", Station7.Text);
                sqlCommand.Parameters.AddWithValue("@St8", Station8.Text);
                sqlCommand.Parameters.AddWithValue("@End", _End.Text);

                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
            }
            MessageBox.Show("Данные были занесены в таблицу рейсов", "Выполенно!", MessageBoxButtons.OK);

            TrainNumber.Text = "";
            _Form.Text = "";
            _To.Text = "";
            _TimeFrom.Text = "";
            _TimeTo.Text = "";
            _CostPl.Text = "";
            _CountPl.Text = "";
            _CostCu.Text = "";
            _CountCu.Text = "";
            _CostCV.Text = "";
            _CountCV.Text = "";
            
            
            _Main.Text = "";
            Station2.Text = "";
            Station3.Text = "";
            Station4.Text = "";
            Station5.Text = "";
            Station6.Text = "";
            Station7.Text = "";
            Station8.Text = "";
            _End.Text = "";
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
