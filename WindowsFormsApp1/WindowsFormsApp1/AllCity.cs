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
    public partial class AllCity : UserControl
    {
        public static string TextLabel;
        public AllCity()
        {
            InitializeComponent();
        }

        public Label CityName
        {
            get { return label1; }
            set { label1 = value; }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (Global.searchTB1.Focused)
            {
                Global.searchTB1.Text = label1.Text;
                Global.searchpanel1.Visible = false;
            }
            else if (Global.searchTB2.Focused)
            {
                Global.searchTB2.Text = label1.Text;
                Global.searchpanel2.Visible = false;
            }
        }


        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(243, 243, 243);
            panel2.BackColor = Color.Red;
            label1.ForeColor = Color.Red;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.Silver;
            label1.ForeColor = Color.Gray;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(243, 243, 243);
            panel2.BackColor = Color.Silver;
            label1.ForeColor = Color.Gray;
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(243, 243, 243);
            panel2.BackColor = Color.Red;
            label1.ForeColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Global.searchTB1.Focused)
            {
                Global.searchTB1.Text = label1.Text;
                Global.searchpanel1.Visible = false;
            }
            else if (Global.searchTB2.Focused)
            {
                Global.searchTB2.Text = label1.Text;
                Global.searchpanel2.Visible = false;
            }
        }

        
    }
}
