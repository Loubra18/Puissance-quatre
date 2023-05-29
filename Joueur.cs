using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puissance_quatre_finale
{
    public class Joueur
    {
        public string Nom;
        public Color Couleur;

        public Joueur(string nom)
        {
            Nom = nom;
        }

        public Color GetCouleurJoueur()
        {
            return Couleur;
        }

        public string GetNomJoueur()
        {
            return Nom;
        }

    }
}
