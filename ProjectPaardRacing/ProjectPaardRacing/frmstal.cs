using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPaardRacing
{
    public partial class frmstal : Form
    {
        public frmstal()
        {
            InitializeComponent();
        }

        private void lblstaleen_Click(object sender, EventArgs e)
        {

        }

        private void frmstal_Load(object sender, EventArgs e)
        {
            lblstaleen.Text = Settings1.Default.Paard1;
            lblstaltwee.Text = Settings1.Default.Paard2;
            lblstaldrie.Text = Settings1.Default.Paard3;

        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
        }

        private void grpBoxKeuze_Enter(object sender, EventArgs e)
        {
        }
        Boolean stal1 = false, stal2 = false, stal3 = false;
        private void rdbPaard1_CheckedChanged(object sender, EventArgs e)
        {
            if (!lblstaleen.Text.Equals("geen"))
            {
                Settings1.Default.stal1check = true;
                Settings1.Default.stal2check = false;
                Settings1.Default.stal3check = false;
                Settings1.Default.GekozenPaard = "Paard1";
                Settings1.Default.Save();
            }
            else
            {
                MessageBox.Show("Je hebt dit paard nog niet gekocht!", "Waarschuwing");
            }
        }

        private void rdbPaard2_CheckedChanged(object sender, EventArgs e)
        {
            if (!lblstaltwee.Text.Equals("geen"))
            {
                Settings1.Default.stal1check = false;
                Settings1.Default.stal2check = true;
                Settings1.Default.stal3check = false;
                Settings1.Default.GekozenPaard = "Paard2";
                Settings1.Default.Save();
            }
            else
            {
                MessageBox.Show("Je hebt dit paard nog niet gekocht!", "Waarschuwing");
            }
        }

        private void rdbPaard3_CheckedChanged(object sender, EventArgs e)
        {
            if(!lblstaldrie.Text.Equals("geen"))
            {
                Settings1.Default.stal1check = false;
                Settings1.Default.stal2check = false;
                Settings1.Default.stal3check = true;
                Settings1.Default.GekozenPaard = "Paard3";
                Settings1.Default.Save();
            }
            else
            {
                MessageBox.Show("Je hebt dit paard nog niet gekocht!", "Waarschuwing");
            }
            
        }
    }
}
