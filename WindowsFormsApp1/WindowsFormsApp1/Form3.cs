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
    public partial class Form3 : Form
    {
        private int _ticks;
        public Form3()
        {
            InitializeComponent();
            Global.buyform = this;
            Global.container = panel3;
            Global.TimerDone = timer1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BuyCard buyCard = new BuyCard();
            panel3.Controls.Add(buyCard);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks == 25)
            {
                Global.container.Controls.Clear();
                BuyDone buyDone = new BuyDone();
                Global.container.Controls.Add(buyDone);
            }           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Global.checklist.Clear();
            Global.ItogCost = 0;
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
