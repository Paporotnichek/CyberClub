
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(42, 76);
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
            this.disciplins.Location = new System.Drawing.Point(42, 148);
            this.disciplins.Name = "disciplins";
            this.disciplins.Size = new System.Drawing.Size(121, 21);
            this.disciplins.TabIndex = 2;
            // 
            // TypeCompetition
            // 
            this.TypeCompetition.FormattingEnabled = true;
            this.TypeCompetition.Location = new System.Drawing.Point(431, 76);
            this.TypeCompetition.Name = "TypeCompetition";
            this.TypeCompetition.Size = new System.Drawing.Size(121, 21);
            this.TypeCompetition.TabIndex = 3;
            // 
            // PrizeMoney
            // 
            this.PrizeMoney.FormattingEnabled = true;
            this.PrizeMoney.Location = new System.Drawing.Point(431, 148);
            this.PrizeMoney.Name = "PrizeMoney";
            this.PrizeMoney.Size = new System.Drawing.Size(121, 21);
            this.PrizeMoney.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(431, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // CreateTournirs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 355);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
    }
}