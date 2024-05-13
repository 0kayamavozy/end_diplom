namespace WindowsFormsApp1
{
    partial class BuyDone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyDone));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(111, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "ВЫПОЛНЕН";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ПЛАТЕЖ НА СУММУ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(360, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 54);
            this.label3.TabIndex = 41;
            this.label3.Text = "₽";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(111, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 54);
            this.label4.TabIndex = 40;
            this.label4.Text = "12500";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Red;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(100, 100);
            this.guna2CircleButton1.Location = new System.Drawing.Point(177, 22);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(148, 148);
            this.guna2CircleButton1.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(111, 415);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 94);
            this.textBox1.TabIndex = 43;
            this.textBox1.Text = "Забронированный билет отправлен Вам на указанную электронную почту.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 23;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(111, 538);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(289, 49);
            this.guna2Button1.TabIndex = 44;
            this.guna2Button1.Text = "НА ГЛАВНУЮ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // BuyDone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuyDone";
            this.Size = new System.Drawing.Size(500, 620);
            this.Load += new System.EventHandler(this.BuyDone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
