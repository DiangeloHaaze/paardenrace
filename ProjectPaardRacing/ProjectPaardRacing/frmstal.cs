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
            lblstaleen.Text = Settings1.Default.Paard1;
            lblstaltwee.Text = Settings1.Default.Paard2;
            lblstaldrie.Text = Settings1.Default.Paard3;
        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
        }
    }
}
