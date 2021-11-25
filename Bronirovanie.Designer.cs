
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
            this.button1 = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.TextBox();
            this.DateSeans = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 8;
            this.button1.TabStop = false;
            this.button1.Text = "Записать игрока";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(371, 131);
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
            this.DateSeans.Location = new System.Drawing.Point(13, 274);
            this.DateSeans.Name = "DateSeans";
            this.DateSeans.Size = new System.Drawing.Size(200, 20);
            this.DateSeans.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
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
            this.label4.Location = new System.Drawing.Point(237, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата окончания сеанса";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bronirovanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateSeans);
            this.Controls.Add(this.start);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.busy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computer);
            this.Controls.Add(this.label2);
            this.Name = "Bronirovanie";
            this.Text = "Занятость зала";
            this.Load += new System.EventHandler(this.Bronirovanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox computer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox busy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox finish;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.DateTimePicker DateSeans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}