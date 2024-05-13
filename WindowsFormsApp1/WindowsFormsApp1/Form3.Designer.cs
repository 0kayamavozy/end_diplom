namespace WindowsFormsApp1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel10.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.ForeColor = System.Drawing.Color.Red;
            this.textBox4.Location = new System.Drawing.Point(303, 42);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(342, 37);
            this.textBox4.TabIndex = 1;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "забронированного билета";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(34, 42);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(304, 37);
            this.textBox3.TabIndex = 0;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Произведите оплату ";
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
            this.button7.TabStop = false;
            this.button7.Text = "🠔";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(114, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 717);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(330, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 624);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 620);
            this.panel3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
    }
}