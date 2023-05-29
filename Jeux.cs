using Puissance_quatre_finale.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Puissance_quatre_finale
{
    public class Jeux
    {
        public int NombreTours { get; private set; } = 0;
        public int NbColonnes { get; private set; } = 7;
        public int NbLignes { get; private set; } = 6;
        public bool[] ColonnesBloquees = new bool[7] { false, false, false, false, false, false, false }; //tableau pour les colonnes bloquées du jetons Mur

        public Button[,] Boutons { get; private set; }
        public int NombreToursDeblocage = 2; //nombre de tours avant de débloquer une colonne

        private Color JoueurCourant = Color.Red; //rouge qui commence
        private Color player2Color = Color.Yellow;

        public Jetons[,] Plateau = new Jetons[6, 7];
        fenêtre_Configuration_Partie Config = new fenêtre_Configuration_Partie();

        public Jeux(Button[,] boutons)
        {

            Boutons = boutons;
        }

        //méthode qui change le joueur courant et vérifier si il y a des colonnes bloquées par un Jetons Mur
        public void ChangerJoueurCourant(ref Color JoueurCourant, ref Color player2Color, ref bool[] ColonnesBloquees)
        {

            // Incrémenter le nombre de tours
            NombreTours++;

            // Changer le joueur courant
            JoueurCourant = (JoueurCourant == Color.Red) ? player2Color : Color.Red;

            // Parcourir les colonnes bloquées pour vérifier s'il faut les débloquer
            for (int i = 0; i < ColonnesBloquees.Length; i++)
            {
                if (ColonnesBloquees[i] == true)
                {
                    // Débloquer la colonne après un certain nombre de tours
                    if (NombreTours >= NombreToursDeblocage)
                    {
                        ColonnesBloquees[i] = false;
                        Debug.WriteLine($"La colonne {i} a été débloquée.");
                    }
                }
            }

            Debug.WriteLine($"C'est maintenant le tour du joueur {JoueurCourant}.");
        }


        public Color GetCouleurJoueurCourant()
        {
            if (JoueurCourant == Color.Red)
                return Color.Red;
            else
                return Color.Yellow;
        }

        public string AfficherCouleurJoueurCourant()
        {
            if (JoueurCourant == Color.Red)
                return "Rouge";
            else
                return "Jaune";
        }

        public void PoserJeton(int colonne)
        {
            Debug.WriteLine("Jeton normal");
            Jetons jetonsNormal = new JetonsNormal(GetCouleurJoueurCourant());
            jetonsNormal.PoserJeton(colonne, ref Plateau, Boutons, NbLignes, ref JoueurCourant, ref player2Color, AfficherCouleurJoueurCourant(), ColonnesBloquees);
            ChangerJoueurCourant(ref JoueurCourant, ref player2Color, ref ColonnesBloquees);
        }

        public void PoserJetonSpeciaux(int colonne)
        {
            Random rand = new Random();
            int random = rand.Next(0, 3); //renvoie un chiffre entre 0 et 2
            switch (random)
            {
                case 0: //Mur
                    Debug.WriteLine("Mur");
                    Jetons mur = new Mur(GetCouleurJoueurCourant());
                    mur.PoserJeton(colonne, ref Plateau, Boutons, NbLignes, ref JoueurCourant, ref player2Color, AfficherCouleurJoueurCourant(), ColonnesBloquees);
                    ChangerJoueurCourant(ref JoueurCourant, ref player2Color, ref ColonnesBloquees);
                    break;

                case 1: //Enclume
                    Debug.WriteLine("Enclume");
                    Jetons enclume = new Enclume(GetCouleurJoueurCourant());
                    enclume.PoserJeton(colonne, ref Plateau, Boutons, NbLignes, ref JoueurCourant, ref player2Color, AfficherCouleurJoueurCourant(), ColonnesBloquees);
                    ChangerJoueurCourant(ref JoueurCourant, ref player2Color, ref ColonnesBloquees);
                    break;

                case 2: //Twist
                    Debug.WriteLine("Twist");
                    Jetons twist = new Twist(GetCouleurJoueurCourant());
                    twist.PoserJeton(colonne, ref Plateau, Boutons, NbLignes, ref JoueurCourant, ref player2Color, AfficherCouleurJoueurCourant(), ColonnesBloquees);
                    ChangerJoueurCourant(ref JoueurCourant, ref player2Color, ref ColonnesBloquees);
                    break;
            }
        }

        public bool AGagne(Button[,] boutons, int ligne, int colonne, Color couleur)
        {
            // Check horizontal direction
            for (int i = 0; i < NbLignes; i++)
            {
                int count = 0;
                for (int j = 0; j < NbColonnes; j++)
                {
                    if (boutons[i, j] != null && boutons[i, j].BackColor == couleur)
                    {
                        count++;
                        if (count == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }

            // Check vertical direction
            for (int j = 0; j < NbColonnes; j++)
            {
                int count = 0;
                for (int i = 0; i < NbLignes; i++)
                {
                    if (boutons[i, j] != null && boutons[i, j].BackColor == couleur)
                    {
                        count++;
                        if (count == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }

            // Check diagonal directions
            for (int i = 0; i < NbLignes; i++)
            {
                for (int j = 0; j < NbColonnes; j++)
                {
                    if (boutons[i, j] != null && boutons[i, j].BackColor == couleur)
                    {
                        // Check diagonal up-right direction
                        if (i >= 3 && j <= 3 &&
                            boutons[i - 1, j + 1] != null && boutons[i - 1, j + 1].BackColor == couleur &&
                            boutons[i - 2, j + 2] != null && boutons[i - 2, j + 2].BackColor == couleur &&
                            boutons[i - 3, j + 3] != null && boutons[i - 3, j + 3].BackColor == couleur)
                        {
                            return true;
                        }

                        // Check diagonal up-left direction
                        if (i >= 3 && j >= 3 &&
                            boutons[i - 1, j - 1] != null && boutons[i - 1, j - 1].BackColor == couleur &&
                            boutons[i - 2, j - 2] != null && boutons[i - 2, j - 2].BackColor == couleur &&
                            boutons[i - 3, j - 3] != null && boutons[i - 3, j - 3].BackColor == couleur)
                        {
                            return true;
                        }

                        // Check diagonal down-right direction
                        if (i <= 2 && j <= 3 &&
                            boutons[i + 1, j + 1] != null && boutons[i + 1, j + 1].BackColor == couleur &&
                            boutons[i + 2, j + 2] != null && boutons[i + 2, j + 2].BackColor == couleur &&
                            boutons[i + 3, j + 3] != null && boutons[i + 3, j + 3].BackColor == couleur)
                        {
                            return true;
                        }

                        // Check diagonal down-left direction
                        if (i <= 2 && j >= 3 &&
                            boutons[i + 1, j - 1] != null && boutons[i + 1, j - 1].BackColor == couleur &&
                            boutons[i + 2, j - 2] != null && boutons[i + 2, j - 2].BackColor == couleur &&
                            boutons[i + 3, j - 3] != null && boutons[i + 3, j - 3].BackColor == couleur)
                        {
                            return true;
                        }
                    }
                }
            }

            // If no winning combination is found, return false
            return false;
        }

    }
}

