using Guna.UI2.WinForms;
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
    public partial class Kype : UserControl
    {
        public Kype()
        {
            InitializeComponent();
            panel2.Visible = false;


            
        }

        public void SetTips()
        {
            TipsHelp th = new TipsHelp();
            panel2.Visible = true;
            panel2.Controls.Add(th);
        }

        private void guna2CustomCheckBox32_MouseEnter(object sender, EventArgs e)
        {
            SetTips();
        }

        private void guna2CustomCheckBox32_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void Kype_Load(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Guna2CustomCheckBox)
                {
                    Guna2CustomCheckBox checkBox = (Guna2CustomCheckBox)control;
                    Global.checklist.Add(checkBox);
                }
            }
        }

        private void guna2CustomCheckBox32_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
