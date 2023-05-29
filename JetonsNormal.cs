using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puissance_quatre_finale
{
    public class JetonsNormal : Jetons
    {
        public JetonsNormal(Color couleur) : base(couleur)
        {
        }

        public override void PoserJeton(int colonne, ref Jetons[,] Plateau, Button[,] Boutons, int NbLignes, ref Color JoueurCourant, ref Color player2Color, string AfficherCouleurJoueurCourant, bool[] ColonnesBloquees)
        {
            for (int ligne = NbLignes - 1; ligne >= 0; ligne--)
            {
                if (Plateau[ligne, colonne] == null)
                {
                    Plateau[ligne, colonne] = new JetonsNormal(JoueurCourant);
                    Boutons[ligne, colonne].BackColor = JoueurCourant;
                    Boutons[ligne, colonne].Visible = true;
                    //JoueurCourant = (JoueurCourant == Color.Red) ? player2Color : Color.Red;
                    break;
                }
            }
        }
    }
}
