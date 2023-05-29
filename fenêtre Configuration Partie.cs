using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puissance_quatre_finale
{
    public partial class fenêtre_Configuration_Partie : Form
    {
        Joueur joueur1;
        Joueur joueur2;
        Jeux plateau;
        public bool utiliserBonus;
        public fenêtre_Configuration_Partie()
        {
            InitializeComponent();
            joueur1 = new Joueur(NomJoueur1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void JouerBouton_Click(object sender, EventArgs e)
        {
            string nomJoueur1 = NomJoueur1.Text;
            string nomJoueur2 = NomJoueur2.Text;
            joueur1 = new Joueur(nomJoueur1);
            joueur2 = new Joueur(nomJoueur2);
            joueur1.GetNomJoueur();
            joueur2.GetNomJoueur();
            Form1 form1 = new Form1(nomJoueur1, nomJoueur2, utiliserBonus);//nomJoueur1 ,//nomJoueur2);
            form1.SetNomsJoueurs(nomJoueur1, nomJoueur2);
            form1.Show();
            this.Hide();
        }

        private void RougeJ1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void JauneJ1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RougeJ2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void fenêtre_Configuration_Partie_Load(object sender, EventArgs e)
        {

        }

        private void JauneJ2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void BonusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            utiliserBonus = true;
        }
    }
}
