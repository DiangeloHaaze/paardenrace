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

        private void frmRace_Load(object sender, EventArgs e)
        {
            lblSaldoBedrag.Text = Convert.ToString(Settings1.Default.Saldo);

        }
        int hoogstesnelheid, laagstesnelheid;
        double totaalbedrag;
        Boolean levens;
        private void btnStart_Click(object sender, EventArgs e)
        {
            //reset de positie van de paarden
            pbx1.Location = new Point(49, 59);
            pbx2.Location = new Point(49, 125);
            pbx3.Location = new Point(49, 196);
            //controleren of er een paard is geselecteerd etc. omdat je anders niet aan de race kan beginnen
            if (Settings1.Default.stal1check == false && Settings1.Default.stal2check == false && Settings1.Default.stal3check == false)
            {
                MessageBox.Show("Je moet eerst een paard selecteren in de stal voordat je kan beginnen racen!", "Waarschuwing");
            }
            else
            {
                //controleerd welk paard is geselecteerd in de stal en past zo de snelheid aan.
                switch (Settings1.Default.GekozenPaard)
                {
                    case "Paard1":
                        laagstesnelheid = 0;
                        hoogstesnelheid = 5;
                        Settings1.Default.Paard1levens = Settings1.Default.Paard1levens - 1;
                        if (Settings1.Default.Paard1levens < 0) { levens = false; } else { levens = true; }

                        break;
                    case "Paard2":
                        laagstesnelheid = 3;
                        hoogstesnelheid = 10;
                        Settings1.Default.Paard2levens = Settings1.Default.Paard1levens - 1;
                        if (Settings1.Default.Paard2levens < 0) { levens = false; } else { levens = true; }
                        break;
                    case "Paard3":
                        laagstesnelheid = 8;
                        hoogstesnelheid = 15;
                        Settings1.Default.Paard3levens = Settings1.Default.Paard1levens - 1;
                        if (Settings1.Default.Paard3levens < 0) { levens = false; } else { levens = true; }
                        break;
                }
                if(levens==false)
                {
                    MessageBox.Show("Je paard is te uitgeput om te spelen, ga naar de markt om voeding voor hem te kopen of kies een ander paard.", "info");
                }
                else { timer1.Start(); }
            }   
           
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
        }

        Random willekeurig = new Random();
        int get1,get2,get3;
        int inzetbedrag;
        private void btnInzetten_Click(object sender, EventArgs e)
        {
            if(!txtInzetten.Text.Equals(""))
            {
               inzetbedrag = Convert.ToInt32(txtInzetten.Text);
                if(inzetbedrag>Settings1.Default.Saldo)
                {
                    MessageBox.Show("Je hebt niet genoeg geld om in te zetten!", "Waarschuwing");
                    inzetbedrag = 0;
                }
                Settings1.Default.Saldo = Settings1.Default.Saldo - inzetbedrag;
                Settings1.Default.Save();
                lblSaldoBedrag.Text = Convert.ToString(Settings1.Default.Saldo);
            }
            txtInzetten.Text = "";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //de paarden blijven racen tot 1 van de paarden op de x coordinaat 700 is.
            if (pbx1.Location.X < 700 && pbx2.Location.X < 700 && pbx3.Location.X < 700)
            {
                get1 = willekeurig.Next(laagstesnelheid, hoogstesnelheid);
                get2 = willekeurig.Next(laagstesnelheid, hoogstesnelheid);
                get3 = willekeurig.Next(laagstesnelheid, hoogstesnelheid);

                pbx1.Left = pbx1.Left+get1+10;
                pbx2.Left = pbx2.Left+get2;
                pbx3.Left = pbx3.Left+get3;
            }
            else
            {
                timer1.Stop();

                if (pbx1.Location.X > 699)
                {
                    totaalbedrag = 50 + (inzetbedrag * 1.5);
                    MessageBox.Show("Profficiat, je paard heeft gewonnen! Je verdient " + totaalbedrag + " euro!", "Resultaat");
                    Settings1.Default.Saldo = Settings1.Default.Saldo + totaalbedrag;
                    Settings1.Default.Save();
                    lblSaldoBedrag.Text = Convert.ToString(Settings1.Default.Saldo);
                    inzetbedrag = 0;
                }
                else
                {
                    MessageBox.Show("Jammer, je bent verloren, je verdient niets.", "Resultaat");
                }
                
            }
        }
    }
}
