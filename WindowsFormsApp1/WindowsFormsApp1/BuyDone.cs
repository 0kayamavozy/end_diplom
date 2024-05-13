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
    public partial class BuyDone : UserControl
    {
        public BuyDone()
        {
            InitializeComponent(); 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Global.checklist.Clear();
            Global.ItogCost = 0;
            Global.mainform.Show();
            Global.buyform.Close();
        }

        private void BuyDone_Load(object sender, EventArgs e)
        {
            label4.Text = Global.ItogLgotCost.ToString();
        }
    }
}
