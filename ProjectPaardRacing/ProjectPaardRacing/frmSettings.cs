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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            //Bij het laden van settings dat bij gebruikersnaam je naam automatisch tevoorschijn komt.
            String naam = txtgebruiker.Text;
            txtgebruiker.Text = frminloggen.username;
        }

        private void Txtgebruiker_TextChanged(object sender, EventArgs e)
        {
            //kijkt of de je de naam hebt aangepast en past deze direct aan. Als je alles verwijdert komt de gebruikersnaam
            // op anoniem te staan en word dit de gebruikersnaam(Diangelo)
            String naam = txtgebruiker.Text;
            if (naam.Equals(""))
            {
                txtgebruiker.Text = "anoniem";
            }
            else
            {
                frminloggen.username = txtgebruiker.Text;
            }
        }

        private void Btnterug_Click(object sender, EventArgs e)
        {
            //Knop om terug naar het startscherm te gaan.
            frmStartPagina frm = new frmStartPagina();
            frm.Show();
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

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }

        private void Rdbgrijs_CheckedChanged(object sender, EventArgs e)
        {
            kleurwissel(5);
        }

        private void Rdbgeel_CheckedChanged(object sender, EventArgs e)
        {
            kleurwissel(1);
        }
    }
}
