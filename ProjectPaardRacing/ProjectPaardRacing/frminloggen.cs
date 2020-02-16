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
            //Daarna word de gebruiker doorverstuurd naar het startscherm. Wat er nog moet gedaan worden is foutcontrole op de ingegeven text om te zien of deze niet
            //leeg is. (Diangelo)
            username = txtgebruikersnaam.Text;
            frmStartPagina frm = new frmStartPagina();
            frm.Show();
            this.Hide();
        }
    }
}
