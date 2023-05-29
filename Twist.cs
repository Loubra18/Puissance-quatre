using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Puissance_quatre_finale
{
    internal class Twist : Jetons
    {
        public Twist(Color couleur) : base(couleur)
        {
        }


        public override void PoserJeton(int colonne, ref Jetons[,] Plateau, Button[,] Boutons, int NbLignes, ref Color JoueurCourant, ref Color player2Color, string AfficherCouleurJoueurCourant, bool[] ColonnesBloquees)
        {
            Debug.WriteLine("Twist");
            //Vérifier si la colonne est valide
            if (colonne < 0 || colonne >= 7)
            {
                return;
            }

            //Rechercher le dernier jeton placé dans la colonne
            int ligneDernierJeton = -1;
            for (int ligne = NbLignes - 1; ligne >= 0; ligne--)
            {
                if (Plateau[ligne, colonne] != null)
                {
                    ligneDernierJeton = ligne;
                    break;
                }

                if (AfficherCouleurJoueurCourant == "Rouge")
                {
                    Boutons[NbLignes - 1, colonne].Image = Properties.Resources.TwistRouge;
                }
                else if (AfficherCouleurJoueurCourant == "Jaune")
                {
                    Boutons[NbLignes - 1, colonne].Image = Properties.Resources.TwistJaune;
                }
                Boutons[NbLignes - 1, colonne].Visible = true;

            }

            //Si aucun jeton n'a été placé dans la colonne, poser un jeton "Twist" de la couleur du joueur courant
            if (ligneDernierJeton == -1)
            {
                Plateau[NbLignes - 1, colonne] = new Twist(JoueurCourant);
                Boutons[NbLignes - 1, colonne].BackColor = JoueurCourant;
                if (AfficherCouleurJoueurCourant == "Rouge")
                {
                    Boutons[NbLignes - 1, colonne].Image = Properties.Resources.TwistRouge;
                }
                else if (AfficherCouleurJoueurCourant == "Jaune")
                {
                    Boutons[NbLignes - 1, colonne].Image = Properties.Resources.TwistJaune;
                }
                Boutons[NbLignes - 1, colonne].Visible = true;
            }
            else
            {
                //Changer la couleur du jeton situé en dessous du jeton "Twist"
                int ligneJetonEnDessous = ligneDernierJeton + 1;
                if (ligneJetonEnDessous < NbLignes)
                {
                    Color couleurOpposee = (Plateau[ligneJetonEnDessous, colonne].Couleur == Color.Red) ? player2Color : Color.Red;
                    Plateau[ligneJetonEnDessous, colonne].Couleur = couleurOpposee;
                    Boutons[ligneJetonEnDessous, colonne].BackColor = couleurOpposee;
                }
            }

            //Changer de joueur
            //JoueurCourant = (JoueurCourant == Color.Red) ? player2Color : Color.Red;

        }
    }
}
