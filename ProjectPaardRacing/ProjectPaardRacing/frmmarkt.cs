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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            // knop om terug te keren naar de game form
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
        }

        private void pcbitemeen_Click(object sender, EventArgs e)
        {

        }

        private void btnkoopitemeen_Click(object sender, EventArgs e)
        {
            //Het aankopen en betalen van item 1
            if (Settings1.Default.Saldo > 249)
            {
                Settings1.Default.Aantalitem1 += 1;
                Settings1.Default.Saldo -= 250;
                Settings1.Default.Save();
            }
        }

        private void pcbitemtwee_Click(object sender, EventArgs e)
        {

        }

        private void btnkoopitemtwee_Click(object sender, EventArgs e)
        {
            //Het aankopen en betalen van item 2
            if (Settings1.Default.Saldo > 399)
            {
                Settings1.Default.Aantalitem2 += 1;
                Settings1.Default.Saldo -= 400;
                Settings1.Default.Save();
            }
        }

        private void pcbitemdrie_Click(object sender, EventArgs e)
        {

        }

        private void btnkoopitemdrie_Click(object sender, EventArgs e)
        {
            //Het aankopen en betalen van item 3
            if (Settings1.Default.Saldo > 549)
            {
                Settings1.Default.Aantalitem3 += 1;
                Settings1.Default.Saldo -= 550;
                Settings1.Default.Save();
            }
            
        }

        private void btnkooppaardeen_Click(object sender, EventArgs e)
        {
            //Het kopen van ja
            aankooppaard(100,"Ja");
        }
        private void aankooppaard(int paardprijs,String paardnaam)
        {
            //Hier word gekeken of de gebruiker genoeg funds heeft om een paard te kopen en of er all een paard in de stallen
            //zit en of dit paard niet all eens is gekocht.
            if ((paardprijs - 1) < Settings1.Default.Saldo)
            {
                if (Settings1.Default.Paard1.Equals("geen"))
                {
                    Settings1.Default.Paard1 = paardnaam;
                    Settings1.Default.Saldo = Settings1.Default.Saldo - paardprijs;
                    Settings1.Default.Paard1levens = 3;
                }
                else if (Settings1.Default.Paard2.Equals("geen") && !(Settings1.Default.Paard1.Equals(paardnaam)))
                {
                    Settings1.Default.Paard2 = paardnaam;
                    Settings1.Default.Saldo = Settings1.Default.Saldo - paardprijs;
                    Settings1.Default.Paard2levens = 3;
                }
                else if (Settings1.Default.Paard3.Equals("geen") && !(Settings1.Default.Paard1.Equals(paardnaam)) && !(Settings1.Default.Paard2.Equals(paardnaam)))
                {
                    Settings1.Default.Paard3 = paardnaam;
                    Settings1.Default.Saldo = Settings1.Default.Saldo - paardprijs;
                    Settings1.Default.Paard3levens = 3;
                }
                else
                {
                    MessageBox.Show("Je voldoet niet aan de waarden om dit paard te kopen. Kijk of je genoeg plaatsen in de stallen hebt en of je dit paard niet al hebt gekocht", "Waarschuwing");
                }
            }
            else
            {
                MessageBox.Show("Je hebt niet genoeg fonds");
            }
           
           
            Settings1.Default.Save();
        }

        private void btnkooppaardtwee_Click(object sender, EventArgs e)
        {
            //aankopen van het paard timmy
            aankooppaard(500,"Timmy");
        }

        private void btnkooppaarddrie_Click(object sender, EventArgs e)
        {
            //aankopen van het paard Margot
            aankooppaard(1000,"Margot");
        }

        private void frmmarkt_FormClosed(object sender, FormClosedEventArgs e)
        {
            // bij het sluiten van de form teruggestuurd worden naar de game form
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
        }
    }
}
