namespace WindowsFormsApp1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this._Message = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._Pass = new Guna.UI2.WinForms.Guna2TextBox();
            this._Login = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1424, 44);
            this.guna2Panel2.TabIndex = 102;
            this.guna2Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseDown);
            this.guna2Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseMove);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.textBox4);
            this.panel10.Controls.Add(this.textBox3);
            this.panel10.Controls.Add(this.button7);
            this.panel10.Location = new System.Drawing.Point(114, 24);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1169, 81);
            this.panel10.TabIndex = 103;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.ForeColor = System.Drawing.Color.Red;
            this.textBox4.Location = new System.Drawing.Point(312, 42);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(334, 37);
            this.textBox4.TabIndex = 100;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "добавления нового рейса";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(34, 42);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(304, 37);
            this.textBox3.TabIndex = 100;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Авторизируйтесь для";
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(34, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 33);
            this.button7.TabIndex = 100;
            this.button7.Text = "🠔";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Location = new System.Drawing.Point(114, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 717);
            this.panel1.TabIndex = 104;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this._Message);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this._Pass);
            this.guna2Panel1.Controls.Add(this._Login);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Location = new System.Drawing.Point(359, 123);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(468, 467);
            this.guna2Panel1.TabIndex = 100;
            // 
            // _Message
            // 
            this._Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Message.ForeColor = System.Drawing.Color.Red;
            this._Message.Location = new System.Drawing.Point(41, 351);
            this._Message.Name = "_Message";
            this._Message.Size = new System.Drawing.Size(385, 23);
            this._Message.TabIndex = 107;
            this._Message.Text = "Неверный логин или пароль";
            this._Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._Message.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(166, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 106;
            this.label1.Text = "Авторизация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // _Pass
            // 
            this._Pass.BorderColor = System.Drawing.Color.DarkGray;
            this._Pass.BorderThickness = 2;
            this._Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._Pass.DefaultText = "";
            this._Pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._Pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._Pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._Pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._Pass.FocusedState.BorderColor = System.Drawing.Color.Red;
            this._Pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Pass.ForeColor = System.Drawing.Color.Black;
            this._Pass.HoverState.BorderColor = System.Drawing.Color.Red;
            this._Pass.Location = new System.Drawing.Point(41, 295);
            this._Pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._Pass.Name = "_Pass";
            this._Pass.PasswordChar = '*';
            this._Pass.PlaceholderForeColor = System.Drawing.Color.Silver;
            this._Pass.PlaceholderText = "Введите пароль";
            this._Pass.SelectedText = "";
            this._Pass.Size = new System.Drawing.Size(385, 36);
            this._Pass.TabIndex = 104;
            // 
            // _Login
            // 
            this._Login.BorderColor = System.Drawing.Color.DarkGray;
            this._Login.BorderThickness = 2;
            this._Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._Login.DefaultText = "";
            this._Login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._Login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._Login.FocusedState.BorderColor = System.Drawing.Color.Red;
            this._Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Login.ForeColor = System.Drawing.Color.Black;
            this._Login.HoverState.BorderColor = System.Drawing.Color.Red;
            this._Login.Location = new System.Drawing.Point(41, 235);
            this._Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._Login.Name = "_Login";
            this._Login.PasswordChar = '\0';
            this._Login.PlaceholderForeColor = System.Drawing.Color.Silver;
            this._Login.PlaceholderText = "Введите логин";
            this._Login.SelectedText = "";
            this._Login.Size = new System.Drawing.Size(385, 36);
            this._Login.TabIndex = 103;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Red;
            this.guna2Button1.Location = new System.Drawing.Point(41, 391);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(385, 45);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Авторизироваться";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            this.guna2Button1.MouseEnter += new System.EventHandler(this.guna2Button1_MouseEnter);
            this.guna2Button1.MouseLeave += new System.EventHandler(this.guna2Button1_MouseLeave);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 884);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.guna2Panel2);
            this.MaximumSize = new System.Drawing.Size(1440, 900);
            this.MinimumSize = new System.Drawing.Size(1440, 900);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox _Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox _Pass;
        private System.Windows.Forms.Label _Message;
    }
}