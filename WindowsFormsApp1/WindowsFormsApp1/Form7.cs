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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
