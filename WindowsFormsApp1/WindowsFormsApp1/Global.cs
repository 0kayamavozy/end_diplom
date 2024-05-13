using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Global
    {
        public static int plackart;
        public static int kype;
        public static int cv;

        public static int CostPl;
        public static int CostKype;
        public static int CostCV;

        public static int ItogCost = 0;

        public static string NameCity;

        public static FlowLayoutPanel searchpanel1;
        public static FlowLayoutPanel searchpanel2;

        public static Guna.UI2.WinForms.Guna2TextBox searchTB1;
        public static Guna.UI2.WinForms.Guna2TextBox searchTB2;

        public static Panel panelCV;
        public static Panel panelPL;

        public static int countpass;

        public static List<Guna2CustomCheckBox> checklist = new List<Guna2CustomCheckBox>();

        public static Form1 mainform;
        public static Form2 buytrain;
        public static Form3 buyform;

        public static Panel container;

        public static Timer TimerDone;

        public static int ItogLgotCost;

        public static bool isLogging;

        public static string Mail;

        public static string HostServer = @"(localdb)\mssqllocaldb";
    }
}


