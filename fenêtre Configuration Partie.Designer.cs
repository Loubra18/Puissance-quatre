namespace Puissance_quatre_finale
{
    partial class fenêtre_Configuration_Partie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Joueur1Label = new System.Windows.Forms.Label();
            this.NomJoueur1 = new System.Windows.Forms.TextBox();
            this.Joueur2Label = new System.Windows.Forms.Label();
            this.NomJoueur2 = new System.Windows.Forms.TextBox();
            this.BonusCheckBox = new System.Windows.Forms.CheckBox();
            this.JouerBouton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Joueur1Label
            // 
            this.Joueur1Label.AutoSize = true;
            this.Joueur1Label.Location = new System.Drawing.Point(59, 45);
            this.Joueur1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Joueur1Label.Name = "Joueur1Label";
            this.Joueur1Label.Size = new System.Drawing.Size(110, 16);
            this.Joueur1Label.TabIndex = 0;
            this.Joueur1Label.Text = "Nom du joueur 1 :";
            this.Joueur1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // NomJoueur1
            // 
            this.NomJoueur1.Location = new System.Drawing.Point(184, 43);
            this.NomJoueur1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NomJoueur1.Name = "NomJoueur1";
            this.NomJoueur1.Size = new System.Drawing.Size(123, 22);
            this.NomJoueur1.TabIndex = 1;
            // 
            // Joueur2Label
            // 
            this.Joueur2Label.AutoSize = true;
            this.Joueur2Label.Location = new System.Drawing.Point(402, 45);
            this.Joueur2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Joueur2Label.Name = "Joueur2Label";
            this.Joueur2Label.Size = new System.Drawing.Size(110, 16);
            this.Joueur2Label.TabIndex = 2;
            this.Joueur2Label.Text = "Nom du joueur 2 :";
            // 
            // NomJoueur2
            // 
            this.NomJoueur2.Location = new System.Drawing.Point(527, 45);
            this.NomJoueur2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NomJoueur2.Name = "NomJoueur2";
            this.NomJoueur2.Size = new System.Drawing.Size(123, 22);
            this.NomJoueur2.TabIndex = 3;
            // 
            // BonusCheckBox
            // 
            this.BonusCheckBox.AutoSize = true;
            this.BonusCheckBox.Location = new System.Drawing.Point(273, 204);
            this.BonusCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BonusCheckBox.Name = "BonusCheckBox";
            this.BonusCheckBox.Size = new System.Drawing.Size(171, 20);
            this.BonusCheckBox.TabIndex = 8;
            this.BonusCheckBox.Text = "Bonus durant la partie ? ";
            this.BonusCheckBox.UseVisualStyleBackColor = true;
            this.BonusCheckBox.CheckedChanged += new System.EventHandler(this.BonusCheckBox_CheckedChanged);
            // 
            // JouerBouton
            // 
            this.JouerBouton.Location = new System.Drawing.Point(258, 251);
            this.JouerBouton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JouerBouton.Name = "JouerBouton";
            this.JouerBouton.Size = new System.Drawing.Size(195, 68);
            this.JouerBouton.TabIndex = 9;
            this.JouerBouton.Text = "Jouer ! ";
            this.JouerBouton.UseVisualStyleBackColor = true;
            this.JouerBouton.Click += new System.EventHandler(this.JouerBouton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Le joueur 1 commencera par jouer avec les jetons rouge";
            // 
            // fenêtre_Configuration_Partie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JouerBouton);
            this.Controls.Add(this.BonusCheckBox);
            this.Controls.Add(this.NomJoueur2);
            this.Controls.Add(this.Joueur2Label);
            this.Controls.Add(this.NomJoueur1);
            this.Controls.Add(this.Joueur1Label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fenêtre_Configuration_Partie";
            this.Text = "fenêtre_Configuration_Partie";
            this.Load += new System.EventHandler(this.fenêtre_Configuration_Partie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Joueur1Label;
        private System.Windows.Forms.Label Joueur2Label;
        private System.Windows.Forms.Button JouerBouton;
        public System.Windows.Forms.TextBox NomJoueur1;
        public System.Windows.Forms.TextBox NomJoueur2;
        public System.Windows.Forms.CheckBox BonusCheckBox;
        private System.Windows.Forms.Label label1;
    }
}