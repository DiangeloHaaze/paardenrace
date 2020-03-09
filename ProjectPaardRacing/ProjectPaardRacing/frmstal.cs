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
            //het inladen van alle gegevens die moeten getoont worden
            kleurwissel(Settings1.Default.backGroundColorS);
            lblstaleen.Text = Settings1.Default.Paard1;
            lblstaltwee.Text = Settings1.Default.Paard2;
            lblstaldrie.Text = Settings1.Default.Paard3;
            lblaantalgras.Text = Convert.ToString(Settings1.Default.Aantalitem1);
            lblaantalnoten.Text = Convert.ToString(Settings1.Default.Aantalitem2);
            lblaantalmaaltijden.Text = Convert.ToString(Settings1.Default.Aantalitem3);
            paardfoto(Settings1.Default.Paard1, 1);
            paardfoto(Settings1.Default.Paard2, 2);
            paardfoto(Settings1.Default.Paard3, 3);
            paardlevens(1,Settings1.Default.Paard1levens);
            paardlevens(2,Settings1.Default.Paard2levens);
            paardlevens(3, Settings1.Default.Paard3levens);
            string test = Convert.ToString(Settings1.Default.Paard1levens+" "+ Settings1.Default.Paard2levens+" "+ Settings1.Default.Paard3levens);
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
            //button om terug naar de game form te gaan
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
        }

        private void grpBoxKeuze_Enter(object sender, EventArgs e)
        {
        }
        bool stal1 = false, stal2 = false, stal3 = false;
        private void rdbPaard1_CheckedChanged(object sender, EventArgs e)
        {
            //kijkt of er een paard in de stal 1 zit
            if (!Settings1.Default.Paard1.Equals("geen"))
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
            //kijkt of er een paard in de stal 2 zit
            if (!Settings1.Default.Paard2.Equals("geen"))
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
            //kijkt of er een paard in de stal 3 zit
            if (!Settings1.Default.Paard3.Equals("geen"))
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

        private void btngras_Click(object sender, EventArgs e)
        {
            //vermindert het aantal gras en vult de stamina met 1
            if(Settings1.Default.Aantalitem1 > 0)
            {
                
                
                if (paardvoeren(1))
                {
                    Settings1.Default.Aantalitem1 -= 1;
                    lblaantalgras.Text = Convert.ToString(Settings1.Default.Aantalitem1);
                }
            }
            
        }
        private bool paardvoeren(int aantal)
        {
            //het volgende kijkt of het paard genoeg stamina al heeft en of er geen paard in de stal zit
            bool flag = true;
            if (rdbPaard1.Checked && !Settings1.Default.Paard1.Equals("geen") && Settings1.Default.Paard1levens < 3)
            {
                Settings1.Default.Paard1levens += aantal;
                paardlevens(1, Settings1.Default.Paard1levens);
            }
            else if (rdbPaard2.Checked && !Settings1.Default.Paard2.Equals("geen") && Settings1.Default.Paard2levens < 3)
            {
                Settings1.Default.Paard2levens += aantal;
                paardlevens(2, Settings1.Default.Paard2levens);
            }
            else if (rdbPaard3.Checked && !Settings1.Default.Paard3.Equals("geen") && Settings1.Default.Paard3levens < 3)
            {
                Settings1.Default.Paard3levens += aantal;
                paardlevens(3, Settings1.Default.Paard3levens);
            }
            else
            {
                MessageBox.Show("Je kon je paard niet voeren. Dit kon komen doordat jouw paard geen honger heeft of je er geen hebt (aangeduid).");
                flag = false;
            }
            return flag;
        }

        private void btnnoten_Click(object sender, EventArgs e)
        {
            //vermindert het aantal noten en vult de stamina met 2
            if (Settings1.Default.Aantalitem2 > 0)
            {
                if (paardvoeren(2))
                {
                    Settings1.Default.Aantalitem2 -= 1;
                    lblaantalnoten.Text = Convert.ToString(Settings1.Default.Aantalitem2);
                }
                
            }
        }

        private void btnmaaltijd_Click(object sender, EventArgs e)
        {
            //vermindert het aantal maaltijden en vult de stamina met 3
            if (Settings1.Default.Aantalitem3 > 0)
            {

                if (paardvoeren(3))
                {
                    Settings1.Default.Aantalitem3 -= 1;
                    lblaantalnoten.Text = Convert.ToString(Settings1.Default.Aantalitem3);
                }
            }
        }

        private void frmstal_FormClosed(object sender, FormClosedEventArgs e)
        {
            // bij het sluiten van de form terug naar de gamevorm gaan
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
        }

        private void paardfoto(string paard,int keer)
        {
            //kijkt welk paard er word meegegeven en geeft op de correcte plaats de correcte foto
            switch (paard)
            {
                case "Ja":
                    switch (keer)
                    {
                        case 1:
                            pcbstaleen.Image = Properties.Resources.Ja;
                            break;
                        case 2:
                            pcbstaltwee.Image = Properties.Resources.Ja;
                            break;
                        case 3:
                            pcbstaldrie.Image = Properties.Resources.Ja;
                            break;
                    }
                    break;
                case "Timmy":
                    switch (keer)
                    {
                        case 1:
                            pcbstaleen.Image = Properties.Resources.Timmy;
                            break;
                        case 2:
                            pcbstaltwee.Image = Properties.Resources.Timmy;
                            break;
                        case 3:
                            pcbstaldrie.Image = Properties.Resources.Timmy;
                            break;
                    }
                    break;
                case "Margot":
                    switch (keer)
                    {
                        case 1:
                            pcbstaleen.Image = Properties.Resources.Margot;
                            break;
                        case 2:
                            pcbstaltwee.Image = Properties.Resources.Margot;
                            break;
                        case 3:
                            pcbstaldrie.Image = Properties.Resources.Margot;
                            break;
                    }
                    break;
                default:
                    switch (keer)
                    {
                        case 1:
                            pcbstaleen.Image = Properties.Resources.Cross;
                            break;
                        case 2:
                            pcbstaltwee.Image = Properties.Resources.Cross;
                            break;
                        case 3:
                            pcbstaldrie.Image = Properties.Resources.Cross;
                            break;
                    }
                    break;
            }
            
        }
        private void paardlevens(int stal,int levens)
        {
            //verandert de kleuren van de stamina balk
            switch (levens)
            {
                case 1:
                    switch (stal)
                    {
                        case 1:
                            pcbstalstam11.BackColor = Color.Green;
                            pcbstalstam12.BackColor = Color.Red;
                            pcbstalstam13.BackColor = Color.Red;
                            break;
                        case 2:
                            pcbstalstam21.BackColor = Color.Green;
                            pcbstalstam22.BackColor = Color.Red;
                            pcbstalstam23.BackColor = Color.Red;
                            break;
                        case 3:
                            pcbstalstam31.BackColor = Color.Green;
                            pcbstalstam32.BackColor = Color.Red;
                            pcbstalstam33.BackColor = Color.Red;
                            break;
                    }
                    break;
                case 2:
                    switch (stal)
                    {
                        case 1:
                            pcbstalstam11.BackColor = Color.Green;
                            pcbstalstam12.BackColor = Color.Green;
                            pcbstalstam13.BackColor = Color.Red;
                            break;
                        case 2:
                            pcbstalstam21.BackColor = Color.Green;
                            pcbstalstam22.BackColor = Color.Green;
                            pcbstalstam23.BackColor = Color.Red;
                            break;
                        case 3:
                            pcbstalstam31.BackColor = Color.Green;
                            pcbstalstam32.BackColor = Color.Green;
                            pcbstalstam33.BackColor = Color.Red;
                            break;
                    }
                    break;
                case 3:
                    switch (stal)
                    {
                        case 1:
                            pcbstalstam11.BackColor = Color.Green;
                            pcbstalstam12.BackColor = Color.Green;
                            pcbstalstam13.BackColor = Color.Green;
                            break;
                        case 2:
                            pcbstalstam21.BackColor = Color.Green;
                            pcbstalstam22.BackColor = Color.Green;
                            pcbstalstam23.BackColor = Color.Green;
                            break;
                        case 3:
                            pcbstalstam31.BackColor = Color.Green;
                            pcbstalstam32.BackColor = Color.Green;
                            pcbstalstam33.BackColor = Color.Green;
                            break;
                    }
                    break;
                default:
                    switch (stal)
                    {
                        case 1:
                            pcbstalstam11.BackColor = Color.Red;
                            pcbstalstam12.BackColor = Color.Red;
                            pcbstalstam13.BackColor = Color.Red;
                            break;
                        case 2:
                            pcbstalstam21.BackColor = Color.Red;
                            pcbstalstam22.BackColor = Color.Red;
                            pcbstalstam23.BackColor = Color.Red;
                            break;
                        case 3:
                            pcbstalstam31.BackColor = Color.Red;
                            pcbstalstam32.BackColor = Color.Red;
                            pcbstalstam33.BackColor = Color.Red;
                            break;
                    }
                    break;
            }
        }
    }
}
