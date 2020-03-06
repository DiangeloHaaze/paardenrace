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
    public partial class frmstallen : Form
    {
        public frmstallen()
        {
            InitializeComponent();
        }

        private void frmstallen_Load(object sender, EventArgs e)
        {
            if (Settings1.Default.Paard1.Equals("Leeg"))
            {
                pcbstal1.Image = Properties.Resources.Leeg;
                pcbstal1.Load();
            }
            if (Settings1.Default.Paard2.Equals("Leeg"))
            {
                pcbstal2.Image = Properties.Resources.Leeg;
            }
            if (Settings1.Default.Paard3.Equals("Leeg"))
            {
                pcbstal3.Image = Properties.Resources.Leeg;
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pcbstal1_Click(object sender, EventArgs e)
        {

        }
    }
}
