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
    internal class Enclume : Jetons
    {
        public Enclume(Color couleur) : base(couleur)
        {
            
        }

        
        public override void PoserJeton(int colonne, ref Jetons[,] Plateau, Button[,] Boutons, int NbLignes, ref Color JoueurCourant, ref Color player2Color, string AfficherCouleurJoueurCourant, bool[] ColonnesBloquees)
        {
            Debug.WriteLine("Enclume");
            // Vérifier si la colonne est valide
            if (colonne < 0 || colonne >= 7)
            {
                return;
            }

            // Supprimer tous les jetons dans la colonne
            for (int ligne = NbLignes - 1; ligne >= 0; ligne--)
            {
                if (Plateau[ligne, colonne] != null)
                {
                    Plateau[ligne, colonne] = null;
                    Boutons[ligne, colonne].BackColor = Color.Transparent;
                    Boutons[ligne, colonne].Visible = false;
                    if (AfficherCouleurJoueurCourant == "Rouge")
                    {
                        Boutons[NbLignes - 1, colonne].Image = Properties.Resources.EnclumeRouge;
                    }
                    else if (AfficherCouleurJoueurCourant == "Jaune")
                    {
                        Boutons[NbLignes - 1, colonne].Image = Properties.Resources.EnclumeJaune;
                    }
                    Boutons[NbLignes - 1, colonne].Visible = true;
                }
            }

            // Poser le jeton "Enclume" en bas de la colonne
            Plateau[NbLignes - 1, colonne] = new Enclume(JoueurCourant);
            Boutons[NbLignes - 1, colonne].BackColor = JoueurCourant;
            if (AfficherCouleurJoueurCourant == "Rouge")
            {
                Boutons[NbLignes - 1, colonne].Image = Properties.Resources.EnclumeRouge;
            }
            else if (AfficherCouleurJoueurCourant == "Jaune")
            {
                Boutons[NbLignes - 1, colonne].Image = Properties.Resources.EnclumeJaune;
            }
            Boutons[NbLignes - 1, colonne].Visible = true;

            // Changer de joueur
            //JoueurCourant = (JoueurCourant == Color.Red) ? player2Color : Color.Red;
        }
    }
}
