using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (_Login.Text == "Admin" && _Pass.Text == "12345")
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();
                Global.isLogging = true;
            }
            else
            {
                _Login.Text = "";
                _Pass.Text = "";
                _Message.Visible = true;
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
        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Move1(e);
        }

        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Move2(e);
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.Red;
            guna2Button1.ForeColor = Color.White;
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.LightGray;
            guna2Button1.ForeColor = Color.Red;
        }
    }
}
