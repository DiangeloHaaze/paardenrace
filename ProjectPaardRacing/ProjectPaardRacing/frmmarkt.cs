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
    public partial class frmmarkt : Form
    {
       
        public frmmarkt()
        {
            InitializeComponent();
        }

        private void frmmarkt_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
        }

        private void pcbitemeen_Click(object sender, EventArgs e)
        {

        }

        private void btnkoopitemeen_Click(object sender, EventArgs e)
        {

        }

        private void pcbitemtwee_Click(object sender, EventArgs e)
        {

        }

        private void btnkoopitemtwee_Click(object sender, EventArgs e)
        {

        }

        private void pcbitemdrie_Click(object sender, EventArgs e)
        {

        }

        private void btnkoopitemdrie_Click(object sender, EventArgs e)
        {

        }

        private void btnkooppaardeen_Click(object sender, EventArgs e)
        {
            aankooppaard(100,"Ja");
            Settings1.Default.Paard1levens = 3;
            Settings1.Default.Save();
        }
        private void aankooppaard(int paardprijs,String paardnaam)
        {

            if (Settings1.Default.Paard1.Equals("geen") && (paardprijs-1) < Settings1.Default.Saldo)
            {
                Settings1.Default.Paard1 = paardnaam;
                Settings1.Default.Saldo = Settings1.Default.Saldo - paardprijs;

            }
            else if (Settings1.Default.Paard2.Equals("geen") && !(Settings1.Default.Paard1.Equals(paardnaam)) && (paardprijs-1) < Settings1.Default.Saldo)
            {
                Settings1.Default.Paard2 = paardnaam;
                Settings1.Default.Saldo = Settings1.Default.Saldo - paardprijs;
            }
            else if (Settings1.Default.Paard3.Equals("geen") && !(Settings1.Default.Paard1.Equals(paardnaam)) && !(Settings1.Default.Paard2.Equals(paardnaam)) && (paardprijs-1) < Settings1.Default.Saldo)
            {
                Settings1.Default.Paard3 = paardnaam;
                Settings1.Default.Saldo = Settings1.Default.Saldo - paardprijs;
            }
           
            Settings1.Default.Save();
        }

        private void btnkooppaardtwee_Click(object sender, EventArgs e)
        {
            aankooppaard(500,"Timmy");
            Settings1.Default.Paard2levens = 3;
            Settings1.Default.Save();
        }

        private void btnkooppaarddrie_Click(object sender, EventArgs e)
        {
            aankooppaard(1000,"Margot");
            Settings1.Default.Paard3levens = 3;
            Settings1.Default.Save();
        }
    }
}
