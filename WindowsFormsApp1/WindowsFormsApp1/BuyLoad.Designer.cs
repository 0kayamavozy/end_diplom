namespace WindowsFormsApp1
{
    partial class BuyLoad
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
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.AutoStart = true;
            this.guna2WinProgressIndicator1.CircleSize = 2F;
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(156, 88);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.NumberOfCircles = 11;
            this.guna2WinProgressIndicator1.ProgressColor = System.Drawing.Color.Red;
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(200, 191);
            this.guna2WinProgressIndicator1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(80, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "ПОДОЖДИТЕ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(142, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "ОПЕРАЦИЯ ВЫПОЛНЯЕТСЯ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2WinProgressIndicator1);
            this.Name = "BuyLoad";
            this.Size = new System.Drawing.Size(500, 620);
            this.Load += new System.EventHandler(this.BuyLoad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
