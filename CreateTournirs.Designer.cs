
namespace CyberClub
{
    partial class CreateTournirs
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
            this.categories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.disciplins = new System.Windows.Forms.ComboBox();
            this.TypeCompetition = new System.Windows.Forms.ComboBox();
            this.PrizeMoney = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(70, 85);
            this.categories.Name = "categories";
            this.categories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categories.Size = new System.Drawing.Size(121, 21);
            this.categories.TabIndex = 0;
            this.categories.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(163, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Панель создания турнира";
            // 
            // disciplins
            // 
            this.disciplins.FormattingEnabled = true;
            this.disciplins.Location = new System.Drawing.Point(70, 157);
            this.disciplins.Name = "disciplins";
            this.disciplins.Size = new System.Drawing.Size(121, 21);
            this.disciplins.TabIndex = 2;
            this.disciplins.SelectedIndexChanged += new System.EventHandler(this.disciplnis_SelectedIndexChanged);
            // 
            // TypeCompetition
            // 
            this.TypeCompetition.FormattingEnabled = true;
            this.TypeCompetition.Location = new System.Drawing.Point(266, 85);
            this.TypeCompetition.Name = "TypeCompetition";
            this.TypeCompetition.Size = new System.Drawing.Size(121, 21);
            this.TypeCompetition.TabIndex = 3;
            this.TypeCompetition.SelectedIndexChanged += new System.EventHandler(this.TypeCompetiton_SelectedIndexChanged);
            // 
            // PrizeMoney
            // 
            this.PrizeMoney.FormattingEnabled = true;
            this.PrizeMoney.Location = new System.Drawing.Point(266, 157);
            this.PrizeMoney.Name = "PrizeMoney";
            this.PrizeMoney.Size = new System.Drawing.Size(121, 21);
            this.PrizeMoney.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(183, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Создать турнир";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CyberClub.Properties.Resources.exit;
            this.pictureBox4.Location = new System.Drawing.Point(425, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // CreateTournirs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(481, 355);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrizeMoney);
            this.Controls.Add(this.TypeCompetition);
            this.Controls.Add(this.disciplins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTournirs";
            this.Text = "Создание турнира";
            this.Load += new System.EventHandler(this.CreateTournirs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox disciplins;
        private System.Windows.Forms.ComboBox TypeCompetition;
        private System.Windows.Forms.ComboBox PrizeMoney;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}