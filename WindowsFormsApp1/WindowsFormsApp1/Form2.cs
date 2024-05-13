using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form2 : Form
    {
        Point WindowPos;
        
        public Form2()
        {
            InitializeComponent();
            Placsart pl = new Placsart();
            Global.buytrain = this;
            
        }
        Kype kype = new Kype();
        Placsart placsart = new Placsart();
        CV cv = new CV();

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

        public void SetButtonBackColor()
        {
            foreach (Button button in flowLayoutPanel2.Controls)
            {
                if (button.BackColor == Color.Red)
                {
                    button.BackColor = Color.FromArgb(240,240,240);
                    button.ForeColor = Color.Red;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                }
            }
        }

        public void SetButtonForeColor(Button button)
        {
            button.ForeColor = Color.White;
            button.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();           
            flowLayoutPanel1.Controls.Add(kype);
            textBox1.Text = textBox2.Text = button2.Text; ;

            SetButtonBackColor();
            SetButtonForeColor(button2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();        
            flowLayoutPanel1.Controls.Add(kype);
            textBox1.Text = textBox2.Text = button1.Text; ;

            SetButtonBackColor();
            SetButtonForeColor(button1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(placsart);
            textBox1.Text = textBox2.Text = button3.Text; ;

            SetButtonBackColor();
            SetButtonForeColor(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(cv);
            textBox1.Text = textBox2.Text = button4.Text;

            SetButtonBackColor();
            SetButtonForeColor(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(kype);
            textBox1.Text = textBox2.Text = button5.Text;

            SetButtonBackColor();
            SetButtonForeColor(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Information.Coach = textBox1.Text;

            int count = 0;
            foreach (var cb in Global.checklist)
            {
                if (cb.Checked)
                {                        
                    count++;
                }                
            }

            int itog;
            if (textBox1.Text == "Вагон 2" || textBox1.Text == "Вагон 3" || textBox1.Text == "Вагон 6")
            {
                itog = Global.CostPl * count;
                Global.ItogCost = itog;
            }

            else if (textBox1.Text == "Вагон 5")
            {
                itog = Global.CostCV * count;
                Global.ItogCost = itog;
            }

            else if (textBox1.Text == "Вагон 4")
            {
                itog = Global.CostKype * count;
                Global.ItogCost = itog;
            }

            Form3 form3 = new Form3();
            form3.Show();
            Global.buytrain.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move1(e);
        }

        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Move2(e);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
