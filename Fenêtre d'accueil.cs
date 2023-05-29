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
    public partial class Fenêtre_d_accueil : Form
    {
        public Fenêtre_d_accueil()
        {
            InitializeComponent();
        }

        private void NouvellePartieBouton_Click(object sender, EventArgs e)
        {
            fenêtre_Configuration_Partie Config = new fenêtre_Configuration_Partie();
            Config.Show();
            this.Hide();
        }

        private void RèglesBouton_Click(object sender, EventArgs e)
        {
            RèglesJeu règles = new RèglesJeu();
            règles.Show();
            this.Hide();
        }

        private void QuitterBouton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
