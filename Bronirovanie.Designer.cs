
namespace CyberClub
{
    partial class Bronirovanie
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
            this.label2 = new System.Windows.Forms.Label();
            this.computer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.busy = new System.Windows.Forms.ComboBox();
            this.Zapis = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.TextBox();
            this.DateSeans = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // computer
            // 
            this.computer.BackColor = System.Drawing.Color.White;
            this.computer.FormattingEnabled = true;
            this.computer.Location = new System.Drawing.Point(92, 60);
            this.computer.Name = "computer";
            this.computer.Size = new System.Drawing.Size(121, 21);
            this.computer.TabIndex = 4;
            this.computer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // busy
            // 
            this.busy.FormattingEnabled = true;
            this.busy.Location = new System.Drawing.Point(92, 126);
            this.busy.Name = "busy";
            this.busy.Size = new System.Drawing.Size(121, 21);
            this.busy.TabIndex = 6;
            // 
            // Zapis
            // 
            this.Zapis.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Zapis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Zapis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Zapis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zapis.ForeColor = System.Drawing.SystemColors.Info;
            this.Zapis.Location = new System.Drawing.Point(357, 278);
            this.Zapis.Name = "Zapis";
            this.Zapis.Size = new System.Drawing.Size(105, 39);
            this.Zapis.TabIndex = 8;
            this.Zapis.TabStop = false;
            this.Zapis.Text = "Записать игрока";
            this.Zapis.UseVisualStyleBackColor = true;
            this.Zapis.Click += new System.EventHandler(this.button1_Click);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(362, 131);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(100, 20);
            this.finish.TabIndex = 9;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(362, 56);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 20);
            this.start.TabIndex = 10;
            // 
            // DateSeans
            // 
            this.DateSeans.CalendarForeColor = System.Drawing.Color.Maroon;
            this.DateSeans.Location = new System.Drawing.Point(13, 274);
            this.DateSeans.Name = "DateSeans";
            this.DateSeans.Size = new System.Drawing.Size(200, 20);
            this.DateSeans.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(237, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата начала сеанса";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(228, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата окончания сеанса";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(231, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Вернуться";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = global::CyberClub.Properties.Resources.exit;
            this.pictureBox4.Location = new System.Drawing.Point(16, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Bronirovanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(483, 360);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateSeans);
            this.Controls.Add(this.start);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.Zapis);
            this.Controls.Add(this.busy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computer);
            this.Controls.Add(this.label2);
            this.Name = "Bronirovanie";
            this.Text = "Занятость зала";
            this.Load += new System.EventHandler(this.Bronirovanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox computer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox busy;
        private System.Windows.Forms.Button Zapis;
        private System.Windows.Forms.TextBox finish;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.DateTimePicker DateSeans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}