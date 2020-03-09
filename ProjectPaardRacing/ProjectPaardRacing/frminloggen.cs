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
    public partial class frminloggen : Form
    {
        //publieke variabele die de gebruikersnaam doorgeeft.
        public static string username;
        public static double saldo = Settings1.Default.Saldo;
        public frminloggen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            //als men op de inloggen knop drukt word de gebruikersnaam opgeslagen in een publieke variabele die in dan in andere forms zal kunnen gebruikt worden.
            //Daarna word de gebruiker doorverstuurd naar het startscherm. Als men niets heeft ingegeven als naam word een 
            // automatische naam toegewezen 'annoniem' en word deze de gebruikersnaam(Diangelo)
            username = txtgebruikersnaam.Text;
            if(username == "")
            {
                username = "anoniem";
            }
            frmStartPagina frm = new frmStartPagina();
            frm.Show();
            this.Hide();
        }

        private void Frminloggen_Load(object sender, EventArgs e)
        {
            
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
    }
}//test
