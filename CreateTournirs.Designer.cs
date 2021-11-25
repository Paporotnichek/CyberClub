
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
            this.SuspendLayout();
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(24, 97);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(121, 21);
            this.categories.TabIndex = 0;
            this.categories.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Панель создания турнира";
            // 
            // disciplins
            // 
            this.disciplins.FormattingEnabled = true;
            this.disciplins.Location = new System.Drawing.Point(24, 157);
            this.disciplins.Name = "disciplins";
            this.disciplins.Size = new System.Drawing.Size(121, 21);
            this.disciplins.TabIndex = 2;
            this.disciplins.SelectedIndexChanged += new System.EventHandler(this.disciplnis_SelectedIndexChanged);
            // 
            // TypeCompetition
            // 
            this.TypeCompetition.FormattingEnabled = true;
            this.TypeCompetition.Location = new System.Drawing.Point(191, 97);
            this.TypeCompetition.Name = "TypeCompetition";
            this.TypeCompetition.Size = new System.Drawing.Size(121, 21);
            this.TypeCompetition.TabIndex = 3;
            this.TypeCompetition.SelectedIndexChanged += new System.EventHandler(this.TypeCompetiton_SelectedIndexChanged);
            // 
            // PrizeMoney
            // 
            this.PrizeMoney.FormattingEnabled = true;
            this.PrizeMoney.Location = new System.Drawing.Point(191, 157);
            this.PrizeMoney.Name = "PrizeMoney";
            this.PrizeMoney.Size = new System.Drawing.Size(121, 21);
            this.PrizeMoney.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Создать турнир";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CreateTournirs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 355);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrizeMoney);
            this.Controls.Add(this.TypeCompetition);
            this.Controls.Add(this.disciplins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categories);
            this.Name = "CreateTournirs";
            this.Text = "CreateTournirs";
            this.Load += new System.EventHandler(this.CreateTournirs_Load);
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
    }
}