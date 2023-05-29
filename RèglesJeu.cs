using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puissance_quatre_finale
{
    public partial class RèglesJeu : Form
    {
        public RèglesJeu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AccueilBouton_Click(object sender, EventArgs e)
        {
            Fenêtre_d_accueil accueil = new Fenêtre_d_accueil();
            accueil.Show();
            this.Hide();
        }
    }
}
