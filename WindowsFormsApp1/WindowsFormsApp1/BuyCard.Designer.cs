namespace WindowsFormsApp1
{
    partial class BuyCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._dd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalcost = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this._cvv = new Guna.UI2.WinForms.Guna2TextBox();
            this._cardname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._email = new Guna.UI2.WinForms.Guna2TextBox();
            this.checktype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.money = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._sD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._fD = new System.Windows.Forms.Label();
            this._fo = new System.Windows.Forms.Label();
            this._t = new System.Windows.Forms.Label();
            this._s = new System.Windows.Forms.Label();
            this._f = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.CardType = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CardName = new System.Windows.Forms.Label();
            this._fourth = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.addmoney = new Guna.UI2.WinForms.Guna2TextBox();
            this._third = new Guna.UI2.WinForms.Guna2TextBox();
            this._second = new Guna.UI2.WinForms.Guna2TextBox();
            this._first = new Guna.UI2.WinForms.Guna2TextBox();
            this._mm = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.CardType2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cvv = new Guna.UI2.WinForms.Guna2TextBox();
            this.moneypanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardType)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardType2)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.moneypanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dd
            // 
            this._dd.Animated = true;
            this._dd.BorderColor = System.Drawing.Color.Black;
            this._dd.BorderRadius = 5;
            this._dd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._dd.DefaultText = "";
            this._dd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._dd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._dd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._dd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._dd.FocusedState.BorderColor = System.Drawing.Color.Red;
            this._dd.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._dd.ForeColor = System.Drawing.Color.Black;
            this._dd.HoverState.BorderColor = System.Drawing.Color.Red;
            this._dd.Location = new System.Drawing.Point(325, 231);
            this._dd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._dd.MaxLength = 2;
            this._dd.Name = "_dd";
            this._dd.PasswordChar = '\0';
            this._dd.PlaceholderForeColor = System.Drawing.Color.Gray;
            this._dd.PlaceholderText = "00";
            this._dd.SelectedText = "";
            this._dd.Size = new System.Drawing.Size(67, 36);
            this._dd.TabIndex = 7;
            this._dd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._dd.TextChanged += new System.EventHandler(this.guna2TextBox8_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(35, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Введите данные банковской карты\r\n";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(422, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 54);
            this.label3.TabIndex = 39;
            this.label3.Text = "₽";
            // 
            // totalcost
            // 
            this.totalcost.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalcost.ForeColor = System.Drawing.Color.Red;
            this.totalcost.Location = new System.Drawing.Point(248, 365);
            this.totalcost.Name = "totalcost";
            this.totalcost.Size = new System.Drawing.Size(168, 54);
            this.totalcost.TabIndex = 38;
            this.totalcost.Text = "1500";
            this.totalcost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Red;
            this.guna2Button1.Location = new System.Drawing.Point(37, 472);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(427, 46);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "ОПЛАТИТЬ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            this.guna2Button1.MouseEnter += new System.EventHandler(this.guna2Button1_MouseEnter);
            this.guna2Button1.MouseLeave += new System.EventHandler(this.guna2Button1_MouseLeave);
            // 
            // _cvv
            // 
            this._cvv.BorderColor = System.Drawing.Color.Black;
            this._cvv.BorderRadius = 5;
            this._cvv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._cvv.DefaultText = "";
            this._cvv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._cvv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._cvv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._cvv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._cvv.FocusedState.BorderColor = System.Drawing.Color.Red;
            this._cvv.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._cvv.ForeColor = System.Drawing.Color.Black;
            this._cvv.HoverState.BorderColor = System.Drawing.Color.Red;
            this._cvv.Location = new System.Drawing.Point(325, 275);
            this._cvv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cvv.MaxLength = 3;
            this._cvv.Name = "_cvv";
            this._cvv.PasswordChar = '•';
            this._cvv.PlaceholderForeColor = System.Drawing.Color.Gray;
            this._cvv.PlaceholderText = "CVV код";
            this._cvv.SelectedText = "";
            this._cvv.Size = new System.Drawing.Size(139, 36);
            this._cvv.TabIndex = 9;
            this._cvv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._cvv.TextChanged += new System.EventHandler(this._cvv_TextChanged);
            // 
            // _cardname
            // 
            this._cardname.BorderColor = System.Drawing.Color.Black;
            this._cardname.BorderRadius = 5;
            this._cardname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._cardname.DefaultText = "";
            this._cardname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._cardname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._cardname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._cardname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._cardname.FocusedState.BorderColor = System.Drawing.Color.Red;
            this._cardname.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._cardname.ForeColor = System.Drawing.Color.Black;
            this._cardname.HoverState.BorderColor = System.Drawing.Color.Red;
            this._cardname.Location = new System.Drawing.Point(37, 275);
            this._cardname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cardname.Name = "_cardname";
            this._cardname.PasswordChar = '\0';
            this._cardname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this._cardname.PlaceholderText = "Введите имя на карте";
            this._cardname.SelectedText = "";
            this._cardname.Size = new System.Drawing.Size(282, 36);
            this._cardname.TabIndex = 5;
            this._cardname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._cardname.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Сумма к оплате:";
            // 
            // _email
            // 
            this._email.Animated = true;
            this._email.BorderColor = System.Drawing.Color.Black;
            this._email.BorderRadius = 5;
            this._email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._email.DefaultText = "";
            this._email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._email.FocusedState.BorderColor = System.Drawing.Color.Red;
            this._email.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._email.ForeColor = System.Drawing.Color.Black;
            this._email.HoverState.BorderColor = System.Drawing.Color.Red;
            this._email.Location = new System.Drawing.Point(37, 319);
            this._email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._email.Name = "_email";
            this._email.PasswordChar = '\0';
            this._email.PlaceholderForeColor = System.Drawing.Color.Gray;
            this._email.PlaceholderText = "Введите электронную почту";
            this._email.SelectedText = "";
            this._email.Size = new System.Drawing.Size(427, 36);
            this._email.TabIndex = 10;
            this._email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checktype
            // 
            this.checktype.BackColor = System.Drawing.Color.Transparent;
            this.checktype.BorderColor = System.Drawing.Color.Black;
            this.checktype.BorderRadius = 5;
            this.checktype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.checktype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checktype.FocusedColor = System.Drawing.Color.Red;
            this.checktype.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.checktype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checktype.ForeColor = System.Drawing.Color.Black;
            this.checktype.ItemHeight = 30;
            this.checktype.Items.AddRange(new object[] {
            "Стандартный",
            "Студенческий",
            "Льготный",
            "Детский"});
            this.checktype.Location = new System.Drawing.Point(324, 430);
            this.checktype.Name = "checktype";
            this.checktype.Size = new System.Drawing.Size(140, 36);
            this.checktype.TabIndex = 44;
            this.checktype.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(34, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 24);
            this.label7.TabIndex = 45;
            this.label7.Text = "Выберите тип билета";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 15;
            this.guna2GradientPanel1.Controls.Add(this.moneypanel);
            this.guna2GradientPanel1.Controls.Add(this._sD);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this._fD);
            this.guna2GradientPanel1.Controls.Add(this._fo);
            this.guna2GradientPanel1.Controls.Add(this._t);
            this.guna2GradientPanel1.Controls.Add(this._s);
            this.guna2GradientPanel1.Controls.Add(this._f);
            this.guna2GradientPanel1.Controls.Add(this.guna2CircleButton1);
            this.guna2GradientPanel1.Controls.Add(this.CardType);
            this.guna2GradientPanel1.Controls.Add(this.CardName);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(51)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(49, 12);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(312, 168);
            this.guna2GradientPanel1.TabIndex = 46;
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.BackColor = System.Drawing.Color.Transparent;
            this.money.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.money.ForeColor = System.Drawing.Color.White;
            this.money.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.money.Location = new System.Drawing.Point(67, 0);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(89, 32);
            this.money.TabIndex = 55;
            this.money.Text = "150000";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label8.Location = new System.Drawing.Point(32, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 32);
            this.label8.TabIndex = 56;
            this.label8.Text = "₽";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _sD
            // 
            this._sD.AutoSize = true;
            this._sD.BackColor = System.Drawing.Color.Transparent;
            this._sD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._sD.ForeColor = System.Drawing.Color.White;
            this._sD.Location = new System.Drawing.Point(269, 128);
            this._sD.Name = "_sD";
            this._sD.Size = new System.Drawing.Size(21, 16);
            this._sD.TabIndex = 54;
            this._sD.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(260, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "/";
            // 
            // _fD
            // 
            this._fD.AutoSize = true;
            this._fD.BackColor = System.Drawing.Color.Transparent;
            this._fD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._fD.ForeColor = System.Drawing.Color.White;
            this._fD.Location = new System.Drawing.Point(240, 128);
            this._fD.Name = "_fD";
            this._fD.Size = new System.Drawing.Size(21, 16);
            this._fD.TabIndex = 52;
            this._fD.Text = "00";
            // 
            // _fo
            // 
            this._fo.AutoSize = true;
            this._fo.BackColor = System.Drawing.Color.Transparent;
            this._fo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this._fo.ForeColor = System.Drawing.Color.White;
            this._fo.Location = new System.Drawing.Point(231, 80);
            this._fo.Name = "_fo";
            this._fo.Size = new System.Drawing.Size(66, 32);
            this._fo.TabIndex = 51;
            this._fo.Text = "0000";
            // 
            // _t
            // 
            this._t.AutoSize = true;
            this._t.BackColor = System.Drawing.Color.Transparent;
            this._t.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this._t.ForeColor = System.Drawing.Color.White;
            this._t.Location = new System.Drawing.Point(159, 80);
            this._t.Name = "_t";
            this._t.Size = new System.Drawing.Size(66, 32);
            this._t.TabIndex = 50;
            this._t.Text = "0000";
            // 
            // _s
            // 
            this._s.AutoSize = true;
            this._s.BackColor = System.Drawing.Color.Transparent;
            this._s.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this._s.ForeColor = System.Drawing.Color.White;
            this._s.Location = new System.Drawing.Point(87, 80);
            this._s.Name = "_s";
            this._s.Size = new System.Drawing.Size(66, 32);
            this._s.TabIndex = 49;
            this._s.Text = "0000";
            // 
            // _f
            // 
            this._f.AutoSize = true;
            this._f.BackColor = System.Drawing.Color.Transparent;
            this._f.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this._f.ForeColor = System.Drawing.Color.White;
            this._f.Location = new System.Drawing.Point(15, 80);
            this._f.Name = "_f";
            this._f.Size = new System.Drawing.Size(66, 32);
            this._f.TabIndex = 48;
            this._f.Text = "0000";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(265, 30);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(15, 15);
            this.guna2CircleButton1.TabIndex = 47;
            this.guna2CircleButton1.Text = "guna2CircleButton1";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click_1);
            // 
            // CardType
            // 
            this.CardType.BackColor = System.Drawing.Color.Transparent;
            this.CardType.FillColor = System.Drawing.Color.Transparent;
            this.CardType.ImageRotate = 0F;
            this.CardType.Location = new System.Drawing.Point(23, 20);
            this.CardType.Name = "CardType";
            this.CardType.Size = new System.Drawing.Size(65, 45);
            this.CardType.TabIndex = 2;
            this.CardType.TabStop = false;
            // 
            // CardName
            // 
            this.CardName.AutoSize = true;
            this.CardName.BackColor = System.Drawing.Color.Transparent;
            this.CardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardName.ForeColor = System.Drawing.Color.White;
            this.CardName.Location = new System.Drawing.Point(26, 128);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(117, 16);
            this.CardName.TabIndex = 1;
            this.CardName.Text = "NAME SURNAME";
            // 
            // _fourth
            // 
            this._fourth.BorderColor = System.Drawing.Color.Black;
            this._fourth.BorderRadius = 5;
            this._fourth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._fourth.DefaultText = "";
            this._fourth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._fourth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._fourth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._fourth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._fourth.FocusedState.BorderColor = System.Drawing.Color.Red;
            this._fourth.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._fourth.ForeColor = System.Drawing.Color.Black;
            this._fourth.HoverState.BorderColor = System.Drawing.Color.Red;
            this._fourth.Location = new System.Drawing.Point(254, 231);
            this._fourth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._fourth.MaxLength = 4;
            this._fourth.Name = "_fourth";
            this._fourth.PasswordChar = '\0';
            this._fourth.PlaceholderForeColor = System.Drawing.Color.Gray;
            this._fourth.PlaceholderText = "0000";
            this._fourth.SelectedText = "";
            this._fourth.Size = new System.Drawing.Size(65, 36);
            this._fourth.TabIndex = 47;
            this._fourth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._fourth.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(37, 534);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(427, 14);
            this.guna2Separator1.TabIndex = 49;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.Red;
            this.guna2Button2.Location = new System.Drawing.Point(38, 554);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(162, 46);
            this.guna2Button2.TabIndex = 50;
            this.guna2Button2.Text = "Пополнить карту";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // addmoney
            // 
            this.addmoney.BorderColor = System.Drawing.Color.LightGray;
            this.addmoney.BorderRadius = 5;
            this.addmoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addmoney.DefaultText = "";
            this.addmoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addmoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addmoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addmoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addmoney.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.addmoney.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.addmoney.ForeColor = System.Drawing.Color.Black;
            this.addmoney.HoverState.BorderColor = System.Drawing.Color.Red;
            this.addmoney.Location = new System.Drawing.Point(206, 554);
            this.addmoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addmoney.Name = "addmoney";
            this.addmoney.PasswordChar = '\0';
            this.addmoney.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.addmoney.PlaceholderText = "Введите сумму пополнения";
            this.addmoney.SelectedText = "";
            this.addmoney.Size = new System.Drawing.Size(258, 46);
            this.addmoney.TabIndex = 51;
            this.addmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addmoney.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // _third
            // 
            this._third.BorderColor = System.Drawing.Color.Black;
            this._third.BorderRadius = 5;
            this._third.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._third.DefaultText = "";
            this._third.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._third.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._third.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._third.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._third.FocusedState.BorderColor = System.Drawing.Color.Red;
            this._third.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._third.ForeColor = System.Drawing.Color.Black;
            this._third.HoverState.BorderColor = System.Drawing.Color.Red;
            this._third.Location = new System.Drawing.Point(182, 231);
            this._third.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._third.MaxLength = 4;
            this._third.Name = "_third";
            this._third.PasswordChar = '\0';
            this._third.PlaceholderForeColor = System.Drawing.Color.Gray;
            this._third.PlaceholderText = "0000";
            this._third.SelectedText = "";
            this._third.Size = new System.Drawing.Size(65, 36);
            this._third.TabIndex = 52;
            this._third.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._third.TextChanged += new System.EventHandler(this._third_TextChanged);
            // 
            // _second
            // 
            this._second.BorderColor = System.Drawing.Color.Black;
            this._second.BorderRadius = 5;
            this._second.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._second.DefaultText = "";
            this._second.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._second.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._second.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._second.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._second.FocusedState.BorderColor = System.Drawing.Color.Red;
            this._second.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._second.ForeColor = System.Drawing.Color.Black;
            this._second.HoverState.BorderColor = System.Drawing.Color.Red;
            this._second.Location = new System.Drawing.Point(111, 231);
            this._second.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._second.MaxLength = 4;
            this._second.Name = "_second";
            this._second.PasswordChar = '\0';
            this._second.PlaceholderForeColor = System.Drawing.Color.Gray;
            this._second.PlaceholderText = "0000";
            this._second.SelectedText = "";
            this._second.Size = new System.Drawing.Size(65, 36);
            this._second.TabIndex = 53;
            this._second.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._second.TextChanged += new System.EventHandler(this._second_TextChanged);
            // 
            // _first
            // 
            this._first.BorderColor = System.Drawing.Color.Black;
            this._first.BorderRadius = 5;
            this._first.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._first.DefaultText = "";
            this._first.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._first.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._first.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._first.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._first.FocusedState.BorderColor = System.Drawing.Color.Red;
            this._first.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._first.ForeColor = System.Drawing.Color.Black;
            this._first.HoverState.BorderColor = System.Drawing.Color.Red;
            this._first.Location = new System.Drawing.Point(38, 231);
            this._first.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._first.MaxLength = 4;
            this._first.Name = "_first";
            this._first.PasswordChar = '\0';
            this._first.PlaceholderForeColor = System.Drawing.Color.Gray;
            this._first.PlaceholderText = "0000";
            this._first.SelectedText = "";
            this._first.Size = new System.Drawing.Size(65, 36);
            this._first.TabIndex = 54;
            this._first.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._first.TextChanged += new System.EventHandler(this._first_TextChanged);
            // 
            // _mm
            // 
            this._mm.Animated = true;
            this._mm.BorderColor = System.Drawing.Color.Black;
            this._mm.BorderRadius = 5;
            this._mm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._mm.DefaultText = "";
            this._mm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._mm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._mm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._mm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._mm.FocusedState.BorderColor = System.Drawing.Color.Red;
            this._mm.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._mm.ForeColor = System.Drawing.Color.Black;
            this._mm.HoverState.BorderColor = System.Drawing.Color.Red;
            this._mm.Location = new System.Drawing.Point(397, 231);
            this._mm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._mm.MaxLength = 2;
            this._mm.Name = "_mm";
            this._mm.PasswordChar = '\0';
            this._mm.PlaceholderForeColor = System.Drawing.Color.Gray;
            this._mm.PlaceholderText = "00";
            this._mm.SelectedText = "";
            this._mm.Size = new System.Drawing.Size(67, 36);
            this._mm.TabIndex = 55;
            this._mm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._mm.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_1);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.BorderRadius = 15;
            this.guna2GradientPanel2.BorderThickness = 1;
            this.guna2GradientPanel2.Controls.Add(this.guna2CircleButton2);
            this.guna2GradientPanel2.Controls.Add(this.CardType2);
            this.guna2GradientPanel2.Controls.Add(this.guna2CustomGradientPanel1);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(51)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(140, 27);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(312, 168);
            this.guna2GradientPanel2.TabIndex = 56;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Location = new System.Drawing.Point(282, 82);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(15, 15);
            this.guna2CircleButton2.TabIndex = 58;
            this.guna2CircleButton2.Text = "guna2CircleButton2";
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // CardType2
            // 
            this.CardType2.BackColor = System.Drawing.Color.Transparent;
            this.CardType2.FillColor = System.Drawing.Color.Transparent;
            this.CardType2.ImageRotate = 0F;
            this.CardType2.Location = new System.Drawing.Point(235, 14);
            this.CardType2.Name = "CardType2";
            this.CardType2.Size = new System.Drawing.Size(65, 45);
            this.CardType2.TabIndex = 57;
            this.CardType2.TabStop = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.cvv);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(205, 114);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(93, 40);
            this.guna2CustomGradientPanel1.TabIndex = 57;
            // 
            // cvv
            // 
            this.cvv.Animated = true;
            this.cvv.BorderColor = System.Drawing.Color.Transparent;
            this.cvv.BorderRadius = 5;
            this.cvv.BorderThickness = 0;
            this.cvv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cvv.DefaultText = "";
            this.cvv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cvv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cvv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cvv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cvv.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.cvv.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cvv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.cvv.HoverState.BorderColor = System.Drawing.Color.Red;
            this.cvv.Location = new System.Drawing.Point(20, 4);
            this.cvv.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cvv.MaxLength = 2;
            this.cvv.Name = "cvv";
            this.cvv.PasswordChar = '\0';
            this.cvv.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.cvv.PlaceholderText = "cvv";
            this.cvv.SelectedText = "";
            this.cvv.Size = new System.Drawing.Size(66, 31);
            this.cvv.TabIndex = 56;
            this.cvv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moneypanel
            // 
            this.moneypanel.BackColor = System.Drawing.Color.Transparent;
            this.moneypanel.Controls.Add(this.money);
            this.moneypanel.Controls.Add(this.label8);
            this.moneypanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.moneypanel.Location = new System.Drawing.Point(91, 25);
            this.moneypanel.Name = "moneypanel";
            this.moneypanel.Size = new System.Drawing.Size(159, 34);
            this.moneypanel.TabIndex = 57;
            // 
            // BuyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._mm);
            this.Controls.Add(this._first);
            this.Controls.Add(this._second);
            this.Controls.Add(this._third);
            this.Controls.Add(this.addmoney);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this._fourth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checktype);
            this.Controls.Add(this._email);
            this.Controls.Add(this._dd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalcost);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this._cvv);
            this.Controls.Add(this._cardname);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Name = "BuyCard";
            this.Size = new System.Drawing.Size(500, 620);
            this.Load += new System.EventHandler(this.BuyCard_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardType)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardType2)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.moneypanel.ResumeLayout(false);
            this.moneypanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox _dd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalcost;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox _cvv;
        private Guna.UI2.WinForms.Guna2TextBox _cardname;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox _email;
        private Guna.UI2.WinForms.Guna2ComboBox checktype;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox CardType;
        private System.Windows.Forms.Label CardName;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2TextBox _fourth;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox addmoney;
        private Guna.UI2.WinForms.Guna2TextBox _third;
        private Guna.UI2.WinForms.Guna2TextBox _second;
        private Guna.UI2.WinForms.Guna2TextBox _first;
        private System.Windows.Forms.Label _fo;
        private System.Windows.Forms.Label _t;
        private System.Windows.Forms.Label _s;
        private System.Windows.Forms.Label _f;
        private Guna.UI2.WinForms.Guna2TextBox _mm;
        private System.Windows.Forms.Label _sD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _fD;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2PictureBox CardType2;
        private Guna.UI2.WinForms.Guna2TextBox cvv;
        private System.Windows.Forms.FlowLayoutPanel moneypanel;
    }
}
