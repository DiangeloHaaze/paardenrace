using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProjectPaardRacing
{
    public partial class frmGame : Form
    {
        public static String aantalpaarden = Settings1.Default.Paard1;
        public frmGame()
        {
            InitializeComponent();
        }

        private void Btnbankenrekening_Click(object sender, EventArgs e)
        {
            frmbank frmbank = new frmbank();
            frmbank.Show();
            this.Hide();
        }

        private void BtnOpenmarkt_Click(object sender, EventArgs e)
        {
            frmmarkt markt = new frmmarkt();
            markt.Show();
            this.Hide();
        }

        private void BtnRacebaan_Click(object sender, EventArgs e)
        {
            frmRace race = new frmRace();
            race.Show();
            this.Hide();
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            frmStartPagina startPagina = new frmStartPagina();
            startPagina.Show();
            this.Hide();
        }

        private void FrmGame_Load_1(object sender, EventArgs e)
        {
            //gebruikersnaam checken
            lblGebruikersnaam.Text = frminloggen.username;
            lblSaldoEuro.Text = Convert.ToString(Settings1.Default.Saldo);
        }

        private void btnstallen_Click(object sender, EventArgs e)
        {
            frmstal stal = new frmstal();
            stal.Show();
            this.Hide();
        }
    }
}
