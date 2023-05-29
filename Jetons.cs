using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Puissance_quatre_finale
{
    public abstract class Jetons
    {
        public Color Couleur { get; set; }
        public int _PositionLigne { get; set; }
        public int _PositionColonne { get; set; }
        public string ImagePath { get; set; } 

        public string RegleJeux { get; set; }

        public Jetons(Color couleur)
        {
            Couleur = couleur;
        }

        public virtual void PoserJeton(int colonne, ref Jetons[,] Plateau, Button[,] Boutons, int NbLignes, ref Color JoueurCourant, ref Color player2Color, string AfficherCouleurJoueurCourant, bool[] ColonnesBloquees)
        {
            // Implémentation par défaut pour la classe de base Jetons
            // Cette méthode peut être écrasée dans les classes dérivées
        }

    }
}

