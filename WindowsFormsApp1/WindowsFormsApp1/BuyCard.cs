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
using System.IO;
using Application = Microsoft.Office.Interop.Word.Application;
using Document = Microsoft.Office.Interop.Word.Document;
using Microsoft.Office.Interop.Word;
using System.Net.Sockets;
using System.Web.Caching;

namespace WindowsFormsApp1
{
    public partial class BuyCard : UserControl
    {
        public BuyCard()
        {
            InitializeComponent();
            cvv.UseSystemPasswordChar = true;
            moneypanel.Visible = false;
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.Red;
            guna2Button1.ForeColor = Color.White;
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.WhiteSmoke;
            guna2Button1.ForeColor = Color.Red;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Global.Mail = _email.Text;

            if (
                _first.Text == String.Empty && 
                _second.Text == String.Empty &&
                _third.Text == String.Empty &&
                _fourth.Text == String.Empty &&

                _dd.Text == String.Empty &&
                _mm.Text == String.Empty &&

                _cardname.Text == String.Empty &&
                _cvv.Text == String.Empty &&

                _email.Text == String.Empty &&

                (checktype.Text != "Стандартный" || checktype.Text != "Студенческий" || checktype.Text != "Льготный" || checktype.Text != "Детский")
            )
            {
                MessageBox.Show("Данные карты заполненны некорректно, перепроверьте данные!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (int.Parse(totalcost.Text) > int.Parse(money.Text))
                {
                    MessageBox.Show("Недостаточно средств для совершения операции", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Random rnd = new Random();
                    int number = rnd.Next(100000, 9999999); 

                    int lastmonet = int.Parse(money.Text) - int.Parse(totalcost.Text);
                    File.WriteAllText(path, lastmonet.ToString());

                    Global.container.Controls.Clear();
                    BuyLoad buyLoad = new BuyLoad();
                    Global.container.Controls.Add(buyLoad);

                    
                    Information.EndCost = totalcost.Text;
                    var date = DateTime.Now;

                    string inputfile = $@"{System.Windows.Forms.Application.StartupPath}\Ticket\ticket.docx";
                    string outputfile = $@"{System.Windows.Forms.Application.StartupPath}\DoneTicket\ticket.docx";

                    Dictionary<string, string> currentroute = new Dictionary<string, string>()
                    {
                        {"<DateA>", $"{Information.ArrivalDate}"},
                        {"<TimeA>", $"{Information.Arrival}"},
                        {"<FromA>", $"{Information.From}"},

                        {"<ToD>", $"{Information.To}"},
                        {"<DateD>", $"{Information.DepartureDate}"},
                        {"<TimeD>", $"{Information.Departure}"},

                        {"<TrainNumber>", $"{Information.NumberTrain}"},
                        {"<Coach>", $"{Information.Coach}"},
                        {"<TicketType>", $"{checktype.Text}"},

                        {"<Cost>", $"{Information.Cost}"},
                        {"<EndCost>", $"{Information.EndCost}"},

                        {"<DateNow>", $"{DateTime.Now}"},
                        {"<RndNumber>", $"{number}"},

                        {"<year>",$"{DateTime.Now.ToString("yyyy")}"},

                        {"<NamePass>", $"{_cardname.Text.ToUpper()}"}
                    };             

                    if (ReplaceTags(inputfile, outputfile, currentroute) == true)
                    {
                        MessageBox.Show("Билет успешно сформирован", "Сообщение", MessageBoxButtons.OK);
                    }
                }
            }
        }

        public static bool ReplaceTags(string input, string output, Dictionary<string, string> tags)
        {
            Application word = new Application();
            try
            {
                Document document = word.Documents.Open(input, ReadOnly:  true);
                Range range = document.Content;
                Document newdocument = word.Documents.Add();

                range.Copy();
                newdocument.Range().Paste();

                foreach(var replace in tags)
                {
                    newdocument.Content.Find.Execute(FindText: replace.Key, ReplaceWith: replace.Value, Replace: WdReplace.wdReplaceAll);
                }

                newdocument.SaveAs2(output);
                newdocument.Close(SaveChanges: false);

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
                return false;
            }
            finally
            {
                word.Quit();
            }
        }

        private void BuyCard_Load(object sender, EventArgs e)
        {
            var itog = Global.ItogCost;

            totalcost.Text = itog.ToString();
            checktype.Text = checktype.Items[0].ToString();

            string moneyformtxt = File.ReadAllText(path);
            if (moneyformtxt == string.Empty)
                money.Text = "0";
            else money.Text = moneyformtxt;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (checktype.Text)
            {
                case "Стандартный":
                    totalcost.Text = Global.ItogCost.ToString(); Global.ItogLgotCost = Convert.ToInt32(totalcost.Text); break; 

                case "Студенческий":
                    totalcost.Text = (Global.ItogCost / 2).ToString(); Global.ItogLgotCost = Convert.ToInt32(totalcost.Text); break;

                case "Льготный":
                    totalcost.Text = (Global.ItogCost / 2).ToString(); Global.ItogLgotCost = Convert.ToInt32(totalcost.Text); break;

                case "Детский":
                    totalcost.Text = (Global.ItogCost / 3).ToString(); Global.ItogLgotCost = Convert.ToInt32(totalcost.Text); break;
            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        string path = Environment.CurrentDirectory + @"\Log\log.txt";
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int currentmoney = int.Parse(money.Text);
            int totalmoney = currentmoney + int.Parse(addmoney.Text);
            money.Text = totalmoney.ToString();

            File.WriteAllText(path, money.Text);
            addmoney.Text = String.Empty;
        }
        
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            _fo.Text = _fourth.Text;
        }

        private void _first_TextChanged(object sender, EventArgs e)
        {
            
            _f.Text = _first.Text;
            if (_first.Text.Length < 1)
            {
                _first.Text = string.Empty;
                _f.Text = "0000";
            }
            else if (int.Parse(_first.Text) >= 1 && int.Parse(_first.Text) <= 999)
            {
                CardType.Image = null;
                CardType2.Image = null;
            }
            else if (int.Parse(_first.Text) >= 2000 && int.Parse(_first.Text) <= 2999)
            {
                CardType.Image = Properties.Resources.icons8_мир_45;
                CardType2.Image = Properties.Resources.icons8_мир_45;
            }
            else if (int.Parse(_first.Text) >= 3000 && int.Parse(_first.Text) <= 3999)
            {
                CardType.Image = Properties.Resources.icons8_маэстро_45;
                CardType2.Image = Properties.Resources.icons8_маэстро_45;
            }
            else if (int.Parse(_first.Text) >= 4000 && int.Parse(_first.Text) <= 4999)
            {
                CardType.Image = Properties.Resources.icons8_виза_45__1_;
                CardType2.Image = Properties.Resources.icons8_виза_45__1_;
            }
            else if (int.Parse(_first.Text) >= 5000 && int.Parse(_first.Text) <= 5999)
            {
                CardType.Image = Properties.Resources.icons8_mastercard_45;
                CardType2.Image = Properties.Resources.icons8_mastercard_45;
            }
            else if (int.Parse(_first.Text) > 5999)
            {
                _first.Text = "5999";
            }
        }

        private void _second_TextChanged(object sender, EventArgs e)
        {
            _s.Text = _second.Text;
        }

        private void _third_TextChanged(object sender, EventArgs e)
        {
            _t.Text = _third.Text;
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            CardName.Text = _cardname.Text.ToUpper();
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {
            _fD.Text = _dd.Text;
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            _sD.Text = _mm.Text;
        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            moneypanel.Visible = !moneypanel.Visible;
        }

        private void _cvv_TextChanged(object sender, EventArgs e)
        {
            cvv.Text = _cvv.Text;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            cvv.UseSystemPasswordChar = !cvv.UseSystemPasswordChar;
        }
    }
}
