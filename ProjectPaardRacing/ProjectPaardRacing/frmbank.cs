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
    public partial class frmbank : Form
    {
        public frmbank()
        {
            InitializeComponent();
        }

        private void frmbank_Load(object sender, EventArgs e)
        {
            lblsaldo.Text = Convert.ToString(Settings1.Default.Saldo);
        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
        }

        private void leeneen_Click(object sender, EventArgs e)
        {
            leengeld(100);
        }

        private void btntien_Click(object sender, EventArgs e)
        {
            leengeld(1000);
        }

        private void btnvijf_Click(object sender, EventArgs e)
        {
            leengeld(500);
        }
        private void leengeld(int aantal)
        {
            //Code die zorgt dat de saldo van de speler met X aantal word opgetelt. Weet nog niet of ik dit later een ristrictie op ga zetten
            Settings1.Default.Saldo = Settings1.Default.Saldo + aantal;
            lblsaldo.Text = Convert.ToString(Settings1.Default.Saldo);
            Settings1.Default.Save();
        }
    }
}
