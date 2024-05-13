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

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {        
        public UserControl1()
        {
            InitializeComponent();      
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {          
            this.BackColor = Color.Gainsboro;            
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {            
            this.BackColor = Color.White;
        }

        public Label TrainNum
        {
            get { return label4; }
            set { label4 = value;}
        }
        
        public TextBox TimeFrom
        {
            get { return textBox1; }
            set { textBox1 = value; }
        }

        public TextBox From
        {
            get { return textBox11; }
            set { textBox11 = value; }
        }

        public TextBox Where
        {
            get { return textBox12; }
            set { textBox12 = value; }
        }

        public TextBox TimeWhere
        {
            get { return textBox2; }
            set { textBox2 = value; }
        }

        public TextBox CostPlacs
        {
            get { return textBox3; }
            set { textBox3.Text = value.ToString(); }
        }

        public TextBox CountPlacs
        {
            get { return textBox6; }
            set { textBox6.Text = value.ToString(); }
        }

        public TextBox CostKype
        {
            get { return textBox4; }
            set { textBox4.Text = value.ToString(); }
        }

        public TextBox CountKype
        {
            get { return textBox7; }
            set { textBox7.Text = value.ToString(); }
        }

        public TextBox CostCB
        {
            get { return textBox5; }
            set { textBox5.Text = value.ToString(); }
        }

        public TextBox CountCB
        {
            get { return textBox8; }
            set { textBox8.Text = value.ToString(); }
        }

        public TextBox Date
        {
            get { return textBox13; }
            set { textBox13 = value; }
        }

        public TextBox DateFrom
        {
            get { return textBox14; }
            set { textBox14.Text = value.ToString();}
        }

        public TextBox DateWhere
        {
            get { return textBox15; }
            set { textBox15.Text = value.ToString(); }
        }
       

        private void panel3_Click(object sender, EventArgs e)
        {          
            Global.CostPl = Convert.ToInt32(textBox3.Text);
            Global.CostKype = Convert.ToInt32(textBox4.Text);
            Global.CostCV = Convert.ToInt32(textBox5.Text);

            Form2 fm = new Form2();
            fm.Show();
            Global.mainform.Hide();

            Information.Arrival = textBox1.Text;
            Information.Departure = textBox2.Text;

            Information.ArrivalDate = textBox14.Text;
            Information.DepartureDate = textBox15.Text;

            Information.From = textBox11.Text;
            Information.To = textBox12.Text;

            Information.Date = textBox13.Text;
            Information.NumberTrain = label4.Text;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
