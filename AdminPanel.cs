using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberClub
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new CreateTournirs());
            /*this.Hide();
            CreateTournirs cTournirs = new CreateTournirs();
            cTournirs.Show(); */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Bronirovanie());
            /*this.Hide();
            Bronirovanie bron = new Bronirovanie();
            bron.Show(); */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Simulation());
           /* this.Hide();
            Simulation simul = new Simulation();
            simul.Show(); */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Arhiv());
            /*this.Hide();
            Arhiv arh = new Arhiv();
            arh.Show(); */
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
