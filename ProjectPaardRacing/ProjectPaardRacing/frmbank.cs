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
            //bij het laden word het saldo en de achtergrondkleur aangepast naar gelang de juiste waarde
            lblsaldo.Text = Convert.ToString(Settings1.Default.Saldo);
            kleurwissel(Settings1.Default.backGroundColorS);
        }
        private void kleurwissel(int kleur)
        {
            //Dit zorgt ervoor dat bij het aanpassen van het kleur het juiste kleurtje word gepakt en aangepast
            switch (kleur)
            {
                case 1:
                    this.BackColor = Color.Yellow;
                    break;
                case 2:
                    this.BackColor = Color.Red;
                    break;
                case 3:
                    this.BackColor = Color.Blue;
                    break;
                case 4:
                    this.BackColor = Color.Green;
                    break;
                case 5:
                    this.BackColor = Color.Gray;
                    break;
            }
        }
        private void btnterug_Click(object sender, EventArgs e)
        {
            //als men op terug knop drukt om terug te kunnen keren
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
        }

        private void leeneen_Click(object sender, EventArgs e)
        {
            //knop voor 100 euro
            leengeld(100);
        }

        private void btntien_Click(object sender, EventArgs e)
        {
            //knop voor 1000 euro
            leengeld(1000);
        }

        private void btnvijf_Click(object sender, EventArgs e)
        {
            //knop voor 500 euro
            leengeld(500);
        }
        private void leengeld(int aantal)
        {
            //Code die zorgt dat de saldo van de speler met X aantal word opgetelt. Weet nog niet of ik dit later een ristrictie op ga zetten
            Settings1.Default.Saldo = Settings1.Default.Saldo + aantal;
            lblsaldo.Text = Convert.ToString(Settings1.Default.Saldo);
            Settings1.Default.Save();
        }

        private void frmbank_FormClosed(object sender, FormClosedEventArgs e)
        {
            //als men de form closed dat men teruggaat naar de gamepagina
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
        }
    }
}
