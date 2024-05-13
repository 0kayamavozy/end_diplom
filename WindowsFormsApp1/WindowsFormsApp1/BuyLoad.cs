using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BuyLoad : UserControl
    {
        public BuyLoad()
        {
            InitializeComponent();
        }

        private void BuyLoad_Load(object sender, EventArgs e)
        {
            Global.TimerDone.Start();
            SendMessage(Global.Mail);
        }
        private void SendMessage(string mailtext)
        {
            string smtpServer = "smtp.mail.ru";
            int smtpPort = 587;
            string smtpUsername = "danjukov11022004@mail.ru";
            string smtpPassword = "Rgg6DmeQfJzBGCiXb6V8";

            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername);
                    mailMessage.To.Add(mailtext);
                    mailMessage.Subject = "Автоматизированная информационная система: 'Бронирование билетов'. Забронированный билет";
                    mailMessage.Body = "Забронированный Вами билет. Приятной поездки!";
                    mailMessage.Attachments.Add(new Attachment(Environment.CurrentDirectory + @"\DoneTicket\ticket.docx"));

                    try
                    {
                        smtpClient.Send(mailMessage);
                    }
                    catch
                    {
                        MessageBox.Show($"Произошла ошибка при отправке сообщения", "Ошибка");
                    }
                }
            }
        }
    }
}
