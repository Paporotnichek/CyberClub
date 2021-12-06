
namespace CyberClub
{
    partial class Arhiv
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Vnesty = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(151, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // Vnesty
            // 
            this.Vnesty.BackColor = System.Drawing.Color.Black;
            this.Vnesty.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Vnesty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Vnesty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Vnesty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vnesty.ForeColor = System.Drawing.SystemColors.Info;
            this.Vnesty.Location = new System.Drawing.Point(592, 311);
            this.Vnesty.Name = "Vnesty";
            this.Vnesty.Size = new System.Drawing.Size(117, 45);
            this.Vnesty.TabIndex = 1;
            this.Vnesty.Text = "Заполнить таблицу";
            this.Vnesty.UseVisualStyleBackColor = false;
            this.Vnesty.Click += new System.EventHandler(this.Vnesty_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = global::CyberClub.Properties.Resources.exit;
            this.pictureBox4.Location = new System.Drawing.Point(679, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Arhiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(735, 387);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Vnesty);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Arhiv";
            this.Text = "Arhiv";
            this.Load += new System.EventHandler(this.Arhiv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Vnesty;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}