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
    public partial class frmRace : Form
    {
        public frmRace()
        {
            InitializeComponent();
        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            // De knop om terug te gaan naar de vorige pagina
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
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

        private void frmRace_Load(object sender, EventArgs e)
        {
            kleurwissel(frminloggen.kleur);
        }
    }
}
