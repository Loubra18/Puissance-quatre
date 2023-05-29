using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Puissance_quatre_finale
{
    public class Mur : Jetons
    {
        public Mur(Color couleur) : base(couleur)
        {
        }
        public override void PoserJeton(int colonne, ref Jetons[,] Plateau, Button[,] Boutons, int NbLignes, ref Color JoueurCourant, ref Color player2Color, string AfficherCouleurJoueurCourant, bool[] ColonnesBloquees)
        {
            for (int ligne = NbLignes - 1; ligne >= 0; ligne--)
            {
                if (Plateau[ligne, colonne] == null)
                {
                    Plateau[ligne, colonne] = new Mur(JoueurCourant);
                    Boutons[ligne, colonne].BackColor = JoueurCourant;
                    Boutons[ligne, colonne].Visible = true;
                    // Bloquer la colonne pour le joueur adverse
                    ColonnesBloquees[colonne] = true;
                    // Changer de joueur courant
                    //JoueurCourant = (JoueurCourant == Color.Red) ? player2Color : Color.Red;
                    if (AfficherCouleurJoueurCourant == "Rouge")
                    {
                        Boutons[NbLignes - 1, colonne].Image = Properties.Resources.MurRouge;
                    }
                    else if (AfficherCouleurJoueurCourant == "Jaune")
                    {
                        Boutons[NbLignes - 1, colonne].Image = Properties.Resources.MurJaune;
                    }
                    Boutons[NbLignes - 1, colonne].Visible = true;
                    break;
                }
            }
        }
    }
}
