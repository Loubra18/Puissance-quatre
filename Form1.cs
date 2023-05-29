using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Puissance_quatre_finale
{
    public partial class Form1 : Form
    {
        Jeux plateau1;
        private Button[,] Boutons; 
        int NombreTours;
        int BonusMax;
        Joueur Joueur1;
        Joueur Joueur2;
        fenêtre_Configuration_Partie Config = new fenêtre_Configuration_Partie();
        bool utiliserBonus;

        public Form1(string nomJoueur1, string nomJoueur2, bool utiliserBonus)
        {
            InitializeComponent();
            Boutons = new Button[6, 7]; // Initialiser d'abord la variable Boutons
            plateau1 = new Jeux(Boutons); // Utiliser la variable Boutons initialisée
            Dessine42Boutons();
            NombreTours = 0;
            //Max 4 bonus par partie
            BonusMax = 0;
            AfficherImageBouton();
            Joueur1 = new Joueur(nomJoueur1);
            Joueur2 = new Joueur(nomJoueur2);
            this.utiliserBonus = utiliserBonus;
        }

        public void Dessine42Boutons()
        {
            int buttonSize = 79; // Taille des boutons
            int spacing = 2; // Espacement entre les boutons
            int borderWidth = 1; // Largeur de la bordure

            // Création du Panel pour contenir les boutons et les lignes
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Width = 7 * (buttonSize + spacing) + spacing;
            panel.Height = 6 * (buttonSize + spacing) + spacing;
            panel.Left = (panel1.Width - panel.Width) / 2;
            panel.Top = (panel1.Height - panel.Height) / 2;
            panel1.Controls.Add(panel);

            // Création des boutons et des lignes
            for (int col = 0; col < 7; col++)
            {
                for (int ligne = 0; ligne < 6; ligne++)
                {
                    Button button = new Button();

                    button.Width = buttonSize;
                    button.Height = buttonSize;
                    button.Left = col * (buttonSize + spacing);
                    button.Top = ligne * (buttonSize + spacing);
                    button.Visible = true;

                    // Ajouter une bordure aux boutons
                    button.FlatAppearance.BorderColor = Color.Black;
                    button.FlatAppearance.BorderSize = borderWidth;

                    int column = col;
                    button.Click += new System.EventHandler(this.ClicSurBouton);
                    button.Tag = (ligne, col); //on sauve la position de chaque boutons 
                    panel.Controls.Add(button);
                    Boutons[ligne, col] = button;


                    // Créer les lignes verticales
                    if (col < 7)
                    {
                        Label verticalLine = new Label();
                        verticalLine.BackColor = Color.Black;
                        verticalLine.Width = borderWidth;
                        verticalLine.Height = panel.Height;
                        verticalLine.Left = (col + 1) * (buttonSize + spacing) - borderWidth / 2;
                        verticalLine.Top = 0;
                        panel.Controls.Add(verticalLine);
                    }

                    // Créer les lignes horizontales
                    if (ligne < 6)
                    {
                        Label horizontalLine = new Label();
                        horizontalLine.BackColor = Color.Black;
                        horizontalLine.Width = panel.Width;
                        horizontalLine.Height = borderWidth;
                        horizontalLine.Left = 0;
                        horizontalLine.Top = (ligne + 1) * (buttonSize + spacing) - borderWidth / 2;
                        panel.Controls.Add(horizontalLine);
                    }
                }
            }
            //J'affiche pour Debug les valeurs dans mon tableau de Boutons pour voir si j'ai un objet Jetons. 
            AfficherTableauBoutonsPourDebug();
            Joueur1 = new Joueur(Config.NomJoueur1.Text);
            label2.Text = Joueur1.GetNomJoueur() + " à vous de jouer";
        }
        

        
        private void ClicSurBouton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            (int ligne, int colonne) = ((int, int))button.Tag;
            label1.Text = "Position du bouton : Ligne " + ligne + ", Colonne " + colonne;
            NombreTours++;
            label3.Text = "Tours numéro: " + NombreTours;

            if (utiliserBonus && NombreTours > 6 && NombreTours < 11 && BonusMax <= 4)
            {
                Random randomTirageJeton = new Random();
                int tirageJeton = randomTirageJeton.Next(1, 3); //j'ai une chance sur 2 de tomber sur un jeton spécial
                if (tirageJeton == 1)
                {
                    plateau1.PoserJetonSpeciaux(colonne);
                    BonusMax++;
                }
                else
                {
                    plateau1.PoserJeton(colonne);
                }
            }
            else
            {
                plateau1.PoserJeton(colonne);
                //changement du nom du joueur courant 
                if (plateau1.AfficherCouleurJoueurCourant() == "Rouge")
                {
                    label2.Text = Joueur1.GetNomJoueur().Trim() + " à vous de jouer !";
                }
                else
                {
                    label2.Text = Joueur2.GetNomJoueur().Trim() + " à vous de jouer !";
                }

            }

            //Afficher image du Jeton actuel
            AfficherImageBouton();
            //label2.Text = "Joueur " + plateau1.AfficherCouleurJoueurCourant() + " à vous de jouer";
            //AfficherTableauBoutonsPourDebug();
            if (plateau1.AGagne(Boutons, ligne, colonne, plateau1.GetCouleurJoueurCourant()) == true)
            {
                if (plateau1.AfficherCouleurJoueurCourant() == "Rouge")
                {
                    DialogResult Result = MessageBox.Show(Joueur1.GetNomJoueur().Trim()+ " a gagné !"); 
                    if (Result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    DialogResult Result = MessageBox.Show(Joueur2.GetNomJoueur().Trim() + " a gagné !");
                    if (Result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                //cache la fenetre de jeux 
                this.Hide();
                
            }

        }

        public void AfficherTableauBoutonsPourDebug()
        {
            Debug.WriteLine("Contenu du tableau Boutons :");

            for (int ligne = 0; ligne < 6; ligne++)
            {
                for (int colonne = 0; colonne < 7; colonne++)
                {
                    Button bouton = Boutons[ligne, colonne];
                    string couleur = (bouton != null) ? bouton.BackColor.ToString() : "null";
                    Debug.WriteLine($"Boutons[{ligne}, {colonne}] = {couleur}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // quand la derniere fenêtre de jeu Form1.cs se ferme tout le programme se ferme
        {
            Application.Exit();
        }

        public void AfficherImageBouton() //methode qui affiche l'image du bouton sur le coté 
        {
            if (plateau1.AfficherCouleurJoueurCourant() == "Jaune")
            {

                this.pictureBox1.Image = Properties.Resources.Capture_d_écran_2023_05_25_083817;
            }
            else if (plateau1.AfficherCouleurJoueurCourant() == "Rouge")
            {
                this.pictureBox1.Image = Properties.Resources.Capture_d_écran_2023_05_25_083748;
            }
        }
        public void SetNomsJoueurs(string nomJoueur1, string nomJoueur2) // méthode qui initialise les noms des joueurs
        {
            Joueur1 = new Joueur(nomJoueur1);
            Joueur2 = new Joueur(nomJoueur2);
            label2.Text = Joueur1.GetNomJoueur().Trim() + " à vous de jouer !";
        }
    }  
}

