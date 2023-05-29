namespace Puissance_quatre_finale
{
    partial class Fenêtre_d_accueil
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
            this.NouvellePartieBouton = new System.Windows.Forms.Button();
            this.RèglesBouton = new System.Windows.Forms.Button();
            this.QuitterBouton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NouvellePartieBouton
            // 
            this.NouvellePartieBouton.AutoSize = true;
            this.NouvellePartieBouton.Location = new System.Drawing.Point(141, 80);
            this.NouvellePartieBouton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NouvellePartieBouton.Name = "NouvellePartieBouton";
            this.NouvellePartieBouton.Size = new System.Drawing.Size(289, 54);
            this.NouvellePartieBouton.TabIndex = 0;
            this.NouvellePartieBouton.Text = "Nouvelle Partie";
            this.NouvellePartieBouton.UseVisualStyleBackColor = true;
            this.NouvellePartieBouton.Click += new System.EventHandler(this.NouvellePartieBouton_Click);
            // 
            // RèglesBouton
            // 
            this.RèglesBouton.Location = new System.Drawing.Point(175, 162);
            this.RèglesBouton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RèglesBouton.Name = "RèglesBouton";
            this.RèglesBouton.Size = new System.Drawing.Size(215, 36);
            this.RèglesBouton.TabIndex = 1;
            this.RèglesBouton.Text = "Règles du jeu";
            this.RèglesBouton.UseVisualStyleBackColor = true;
            this.RèglesBouton.Click += new System.EventHandler(this.RèglesBouton_Click);
            // 
            // QuitterBouton
            // 
            this.QuitterBouton.Location = new System.Drawing.Point(175, 224);
            this.QuitterBouton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuitterBouton.Name = "QuitterBouton";
            this.QuitterBouton.Size = new System.Drawing.Size(215, 36);
            this.QuitterBouton.TabIndex = 2;
            this.QuitterBouton.Text = "Quitter";
            this.QuitterBouton.UseVisualStyleBackColor = true;
            this.QuitterBouton.Click += new System.EventHandler(this.QuitterBouton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Puissance 4";
            // 
            // Fenêtre_d_accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuitterBouton);
            this.Controls.Add(this.RèglesBouton);
            this.Controls.Add(this.NouvellePartieBouton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Fenêtre_d_accueil";
            this.Text = "Fenêtre_d_accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NouvellePartieBouton;
        private System.Windows.Forms.Button RèglesBouton;
        private System.Windows.Forms.Button QuitterBouton;
        private System.Windows.Forms.Label label1;
    }
}