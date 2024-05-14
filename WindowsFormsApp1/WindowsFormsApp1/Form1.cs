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
using Guna.UI2.WinForms;
using System.Globalization;
using static Guna.UI2.Native.WinApi;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox9.Text = DateTime.Now.ToString();           
            Global.searchpanel1 = flowLayoutPanel5;
            Global.searchpanel2 = flowLayoutPanel6;

            if (Global.isLogging == true)
                guna2Button6.Enabled = true;

            Global.searchTB1 = textBox10;
            Global.searchTB2 = textBox11;
            Global.mainform = this;   
        }
        // установка размера панели (панель фильтров)
        public void SetPanelSize(Button button, Panel panel)
        {
            if (panel.Height != 60)
            {
                panel.Height = 60;
                button.Text = "▼";
            }
            else if (panel.Height == 60)
            {
                panel.Height = 138;
                button.Text = "▲";
            }
        }

        // изменение панелей фильтров 
        private void button6_Click(object sender, EventArgs e)
        {
            SetPanelSize(button6, panel11);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetPanelSize(button7, panel12);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetPanelSize(button8, panel13);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetPanelSize(button9, panel14);
        }    
      
        private void button11_Click(object sender, EventArgs e)
        {           
            panel5.Visible = !panel5.Visible;

            if (button11.Text == "▼")
            {
                button11.Text = "▲";
            }
            else if (button11.Text == "▲")
            {
                button11.Text = "▼";
            }               
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

        // изменение ползунка (цена) фильтров
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = guna2TrackBar1.Value.ToString();
            guna2CircleButton1.Visible = true;
            if (guna2TrackBar1.Value == 150 && guna2TrackBar2.Value == guna2TrackBar2.Minimum)
            {
                guna2CircleButton1.Visible = false;
            }
        }

        // принять дату на календаре
        private void button1_Click(object sender, EventArgs e)
        {
           
            textBox9.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();            
            panel5.Visible = false;
            button11.Text = "▼";
        }

        // изменение свойств кнпоки НАЙТИ 
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Red;
        }

        // отчистка поля ввода ОТКУДА
        private void button13_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
        }

        // отчистка поля ввода КУДА
        private void button14_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
        }

        // изменение ползунка (время в пути) фильтров
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            textBox4.Text = guna2TrackBar2.Value.ToString();
            guna2CircleButton1.Visible = true;
            if (guna2TrackBar1.Value == 150 && guna2TrackBar2.Value == guna2TrackBar2.Minimum)
            {
                guna2CircleButton1.Visible = false;
            }
        }

        // изменение ползунка (отправлениие) фильтров
        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            textBox6.Text = guna2TrackBar3.Value.ToString();
            guna2CircleButton1.Visible = true;
            if (guna2TrackBar3.Value == guna2TrackBar3.Minimum)
            {
                guna2CircleButton1.Visible = false;
            }
        }

        // изменение ползунка (прибытие) фильтров
        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            textBox15.Text = guna2TrackBar4.Value.ToString();
            guna2CircleButton1.Visible = true;
            if (guna2TrackBar4.Value == guna2TrackBar4.Minimum)
            {
                guna2CircleButton1.Visible = false;
            }
        }


        // сообщение о поиске
        public void SetMessageTextBox()
        {
            TextBox message = new TextBox();
            Panel panelmessage = new Panel();

            flowLayoutPanel2.Controls.Clear();

            panelmessage.Width = 643;
            panelmessage.Height = 564;

            message.Font = new Font("Microsoft Sans Serif", 24);
            message.BackColor = Color.FromArgb(233, 234, 237);
            message.ForeColor = Color.Silver;
            message.Text = "По Вашему запросу не найдено рейсов";
            message.Size = new Size(565, 43);
            message.BorderStyle = BorderStyle.None;
            message.ReadOnly = true;

            panelmessage.Controls.Add(message);
            message.Location = new Point(50, 264);

            flowLayoutPanel2.Controls.Add(panelmessage);
        }

        // проверка на ввод точек назначения
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox10.Text == "" && textBox11.Text == "")
            {
                guna2Panel1.BorderColor = Color.Red;
                guna2Panel2.BorderColor = Color.Red;
                SetMessageTextBox();
            }
            else if (textBox10.Text == "")
            {
                guna2Panel1.BorderColor = Color.Red;
                SetMessageTextBox();
            }
            else if (textBox11.Text == "")
            {
                guna2Panel2.BorderColor = Color.Red;
                SetMessageTextBox();
            }
            else
            {
                string sqlConnection = $@"Data Source={Global.HostServer};Initial Catalog=TrainDataBase;Integrated Security=True";
                using (SqlConnection sqlconn = new SqlConnection(sqlConnection))
                {
                    sqlconn.Open();
                    SqlCommand command = new SqlCommand("select * from TrainInfo where @from_ = Otkyda and @to_ = Kyda " +
                        "and @time = Date and (@price < Cost1 or @price < Cost2 or @price < Cost3)", sqlconn);
                    command.Parameters.AddWithValue("@from_", textBox10.Text);
                    command.Parameters.AddWithValue("@to_", textBox11.Text);
                    command.Parameters.AddWithValue("@date_", textBox9.Text);

                    var date_ = Convert.ToDateTime(textBox9.Text).ToString("yyyy-MM-dd");

                    command.Parameters.AddWithValue("@price", textBox1.Text);
                    command.Parameters.AddWithValue("@time", date_);
                    command.Parameters.AddWithValue("@from", textBox6.Text);
                    command.Parameters.AddWithValue("@to", textBox8.Text);

                    SqlDataReader reader = command.ExecuteReader();

                    flowLayoutPanel2.Controls.Clear();
                    while (reader.Read())
                    {
                        UserControl1 traininfo = new UserControl1();
                        traininfo.From.Text = reader.GetString(0);
                        traininfo.Where.Text = reader.GetString(1);

                        traininfo.Date.Text = reader.GetDateTime(2).ToString("dd/MM/yyyy");

                        traininfo.TimeFrom.Text = reader.GetString(4);
                        traininfo.TimeWhere.Text = reader.GetString(5);

                        traininfo.CostPlacs.Text = reader.GetInt32(7).ToString();
                        traininfo.CountPlacs.Text = reader.GetInt32(8).ToString();

                        traininfo.CostKype.Text = reader.GetInt32(10).ToString();
                        traininfo.CountKype.Text = reader.GetInt32(11).ToString();

                        traininfo.CostCB.Text = reader.GetInt32(13).ToString();
                        traininfo.CountCB.Text = reader.GetInt32(14).ToString();

                        traininfo.DateFrom.Text = reader.GetDateTime(15).ToString("dd/MM/yyyy");
                        traininfo.DateWhere.Text = reader.GetDateTime(16).ToString("dd/MM/yyyy");

                        traininfo.TrainNum.Text = reader.GetString(17);
                        flowLayoutPanel2.Controls.Add(traininfo);
                    }
                    reader.Close();
                    sqlconn.Close();

                    var counttrain = flowLayoutPanel2.Controls.Count;
                    label7.Text = "Найдено рейсов: " + counttrain.ToString();


                    guna2Panel1.BorderColor = Color.White;
                    guna2Panel2.BorderColor = Color.White;
                }

                if (flowLayoutPanel2.Controls.Count == 0)
                {
                    SetMessageTextBox();
                }

                
            }
        }

        // показ панелей с городами ОТКУДА
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            SearchPanel(textBox10, flowLayoutPanel5);  
        }

        // показ панелей с городами КУДА
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            SearchPanel(textBox11, flowLayoutPanel6);
        }

        // метод поска городов из баы данных 
        public void SearchPanel(Guna2TextBox textBox, FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                flowLayoutPanel.Visible = true;
                if (textBox.Text != "")
                {
                    flowLayoutPanel.Controls.Clear();
                    string sqlConnection = $@"Data Source={Global.HostServer};Initial Catalog=TrainDataBase;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(sqlConnection);
                    SqlCommand sqlCommand = new SqlCommand("select * from NameCity where NameCity like @NameCity", connection);
                    sqlCommand.Parameters.AddWithValue("@NameCity", string.Format("{0}%", textBox.Text));


                    connection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        AllCity all = new AllCity();
                        all.CityName.Text = reader.GetString(0);
                        flowLayoutPanel.Controls.Add(all);
                    }
                    reader.Close();
                    connection.Close();
                }
                else
                {
                    flowLayoutPanel.Controls.Clear();
                    flowLayoutPanel.Visible = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"При подключении к базе данных произошла ошибка!\n{ex}", "Ошибка");
            }
            
        }

        // установка значения trackbar'a
        public void SetTrackBar(TextBox textbox, Guna2TrackBar trackBar)
        {
            if (textbox.Text == "" && textbox.Focused)
            {
                textbox.Text = "1";
            }
            int value = Convert.ToInt32(textbox.Text);
            if (value > trackBar.Maximum)
            {
                trackBar.Value = trackBar.Maximum;
                textbox.Text = trackBar.Value.ToString();
            }
            else
                trackBar.Value = value;
        }

        // измененеие значений ползунка 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SetTrackBar(textBox1, guna2TrackBar1);
        }

        // редактирование значения textbox цена, с помощью клавиши backspace 
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        // редактирование значений ползунка
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SetTrackBar(textBox4, guna2TrackBar2);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.Red;
            guna2Button1.ForeColor = Color.White;
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.FromArgb(233, 234, 237);
            guna2Button1.ForeColor = Color.Red;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Move2(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move1(e);
        }

        private void guna2Button3_MouseEnter(object sender, EventArgs e)
        {
            guna2Button3.FillColor = Color.Red;
            guna2Button3.ForeColor = Color.White;
        }

        private void guna2Button3_MouseLeave(object sender, EventArgs e)
        {
            guna2Button3.FillColor = Color.FromArgb(233, 234, 237);
            guna2Button3.ForeColor = Color.Red;
        }

        private void guna2Button2_MouseEnter(object sender, EventArgs e)
        {
            guna2Button2.FillColor = Color.Red;
            guna2Button2.ForeColor = Color.White;
        }

        private void guna2Button2_MouseLeave(object sender, EventArgs e)
        {
            guna2Button2.FillColor = Color.FromArgb(233, 234, 237);
            guna2Button2.ForeColor = Color.Red;
        }

        // кнпока СБРОСИТЬ фильтры
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2TrackBar1.Value = 150;
            guna2TrackBar2.Value = guna2TrackBar2.Minimum;
            guna2TrackBar3.Value = guna2TrackBar3.Minimum;
            guna2TrackBar4.Value = guna2TrackBar4.Minimum;

            panel11.Height = 138;
            button6.Text = "▲";
            panel12.Height = 138;
            button7.Text = "▲";
            panel13.Height = 138;
            button8.Text = "▲";
            panel14.Height = 138;
            button9.Text = "▲";
        }

        // свойства кнпоки СБРОСИТЬ
        private void guna2Button4_MouseEnter(object sender, EventArgs e)
        {
            guna2Button4.FillColor = Color.Red;
            guna2Button4.ForeColor = Color.White;
        }

        private void guna2Button4_MouseLeave(object sender, EventArgs e)
        {
            guna2Button4.FillColor = Color.White;
            guna2Button4.ForeColor = Color.Red;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string temp = textBox10.Text;
            textBox10.Text = textBox11.Text;
            textBox11.Text = temp;

            flowLayoutPanel5.Visible = false;
            flowLayoutPanel6.Visible = false;
        }

        private void guna2Button5_MouseEnter(object sender, EventArgs e)
        {
            guna2Button5.FillColor = Color.Red;
            guna2Button5.Image = Properties.Resources.icons8_sorting_arrows_horizontal_50__1_;
        }

        private void guna2Button5_MouseLeave(object sender, EventArgs e)
        {
            guna2Button5.FillColor = Color.White;
            guna2Button5.Image = Properties.Resources.icons8_sorting_arrows_horizontal_50;
        }

        private void guna2Button6_MouseEnter(object sender, EventArgs e)
        {
            guna2Button6.FillColor = Color.Red;
            guna2Button6.ForeColor = Color.White;
        }

        private void guna2Button6_MouseLeave(object sender, EventArgs e)
        {
            guna2Button6.FillColor = Color.FromArgb(233, 234, 237);
            guna2Button6.ForeColor = Color.Red;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form6 table = new Form6();
            table.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void guna2TrackBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.ShowDialog();
        }

        private void guna2Button7_MouseEnter(object sender, EventArgs e)
        {
            guna2Button7.FillColor = Color.Red;
            guna2Button7.Image = Properties.Resources.icons8_settings_35__1_;
        }

        private void guna2Button7_MouseLeave(object sender, EventArgs e)
        {
            guna2Button7.FillColor = Color.FromArgb(233, 234, 237);
            guna2Button7.Image = Properties.Resources.icons8_settings_35;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            if (Convert.ToInt32(File.ReadAllText(Environment.CurrentDirectory + @"\Log\SaveServer.txt")) == 1)
            {
                Global.HostServer = File.ReadAllText(Environment.CurrentDirectory + @"\Log\Server.txt");
            }
            else
            {
                var result = MessageBox.Show("Необходимо выбрать сервер для подключения.\nВыбрать сервер можно в настройках приложения\nПерейти в настройки?", "Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Form8 form = new Form8();
                    form.ShowDialog();
                }
            }
        }

        private void guna2TrackBar3_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            SetTrackBar(textBox6, guna2TrackBar3);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
