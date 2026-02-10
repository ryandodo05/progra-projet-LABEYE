namespace Manipulation_liste
{
    partial class Listes
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bConfirmer = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.bAjouter = new System.Windows.Forms.Button();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.bOuvrir = new System.Windows.Forms.Button();
            this.lbPersonne = new System.Windows.Forms.ListBox();
            this.cbQualite = new System.Windows.Forms.ComboBox();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.Nom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.Qualité = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.sfdEnregistrer = new System.Windows.Forms.SaveFileDialog();
            this.bModifier = new System.Windows.Forms.Button();
            this.gbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAnnuler
            // 
            this.bAnnuler.Location = new System.Drawing.Point(160, 152);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(145, 35);
            this.bAnnuler.TabIndex = 0;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bConfirmer
            // 
            this.bConfirmer.Location = new System.Drawing.Point(10, 152);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(145, 35);
            this.bConfirmer.TabIndex = 1;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.UseVisualStyleBackColor = true;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // bSupprimer
            // 
            this.bSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSupprimer.Location = new System.Drawing.Point(12, 390);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(145, 35);
            this.bSupprimer.TabIndex = 2;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // bAjouter
            // 
            this.bAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAjouter.Location = new System.Drawing.Point(12, 308);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(145, 35);
            this.bAjouter.TabIndex = 3;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnregistrer.Location = new System.Drawing.Point(12, 256);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(145, 35);
            this.bEnregistrer.TabIndex = 4;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // bOuvrir
            // 
            this.bOuvrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOuvrir.Location = new System.Drawing.Point(12, 215);
            this.bOuvrir.Name = "bOuvrir";
            this.bOuvrir.Size = new System.Drawing.Size(145, 35);
            this.bOuvrir.TabIndex = 5;
            this.bOuvrir.Text = "Ouvrir";
            this.bOuvrir.UseVisualStyleBackColor = true;
            this.bOuvrir.Click += new System.EventHandler(this.bOuvrir_Click);
            // 
            // lbPersonne
            // 
            this.lbPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonne.FormattingEnabled = true;
            this.lbPersonne.ItemHeight = 20;
            this.lbPersonne.Location = new System.Drawing.Point(12, 36);
            this.lbPersonne.Name = "lbPersonne";
            this.lbPersonne.Size = new System.Drawing.Size(483, 164);
            this.lbPersonne.TabIndex = 6;
            this.lbPersonne.SelectedIndexChanged += new System.EventHandler(this.lbPersonne_SelectedIndexChanged);
            // 
            // cbQualite
            // 
            this.cbQualite.FormattingEnabled = true;
            this.cbQualite.Items.AddRange(new object[] {
            "Non spécifié",
            "Neutre",
            "Individu",
            "Personne",
            "Être humain",
            "Utilisateur·rice",
            "Citoyen·ne",
            "Humain·e",
            "Entité",
            "Créature consciente",
            "Créature semi‑consciente",
            "Créature pas très réveillée",
            "Être approximatif",
            "Être conceptuel",
            "Être en cours de chargement",
            "Processus en attente",
            "Instance temporaire",
            "Prototype social",
            "Version bêta de soi-même",
            "Utilisateur·rice mystère",
            "Personne en surcharge cognitive",
            "Âme en roaming",
            "Voyageur·se immobile",
            "Rêveur·se certifié·e",
            "Optimiste sous conditions",
            "Pessimiste intermittent·e",
            "Survivant·e du lundi matin",
            "Champion·ne du bouton snooze",
            "Gardien·ne du dernier neurone actif",
            "Maître·sse du chaos organisé",
            "Expert·e en procrastination",
            "Dompteur·se de bugs",
            "Seigneur·e du clavier",
            "Grand·e Manitou·e",
            "Héros du quotidien",
            "Héroïne du quotidien",
            "Explorateur·rice du bureau encombré",
            "Ambassadeur·rice du sommeil perdu",
            "Agent·e du chaos contrôlé",
            "Coordinateur·rice des tâches inutiles",
            "Responsable des choses floues",
            "Directeur·rice du vide administratif",
            "Consultant·e en décisions discutables",
            "Chef·fe de projet sans projet",
            "Manager de l’imprévu",
            "Technicien·ne en solutions temporaires",
            "Être interdimensionnel",
            "Entité non identifiée",
            "Spectre du réseau local",
            "Ombre du serveur",
            "Variable non déclarée",
            "Exception non gérée",
            "Processus fantôme",
            "Avatar en surcharge",
            "Utilisateur·rice en mode économie d’énergie",
            "Personne en maintenance",
            "Humain·e en mise à jour",
            "Créature caféinée",
            "Survivant·e du café froid",
            "Maître·sse des onglets ouverts",
            "Gardien·ne du mot de passe oublié",
            "Seigneur·e des fichiers non enregistrés",
            "Champion·ne du Ctrl+Z",
            "Roi du Alt+Tab",
            "Reine du Alt+Tab",
            "Explorateur·rice des dossiers mystérieux",
            "Archiviste des choses oubliées",
            "Pilote automatique défaillant",
            "Esprit distrait mais motivé",
            "Être de lumière approximatif",
            "Abonné·e au hasard",
            "Passager·ère du temps qui passe",
            "Curieux·se professionnel·le",
            "Agent·e double du service informatique",
            "Ambassadeur·rice du monde réel",
            "Voyageur·se temporel·le en retard",
            "Habitant·e du multivers administratif",
            "Coordinateur·rice des réalités alternatives",
            "Responsable des décisions spontanées",
            "Gardien·ne des fichiers perdus",
            "Émissaire du bon sens relatif",
            "Navigateur·rice des menus labyrinthiques",
            "Être conceptuel non identifié",
            "Personne en cours d’initialisation",
            "Processus en veille prolongée",
            "Instance oubliée",
            "Objet vaguement utile",
            "Objet vaguement décoratif",
            "Objet non identifié",
            "Objet trouvé",
            "Objet perdu",
            "Objet qui traîne",
            "Chaise",
            "Table",
            "Lampe",
            "Stylo",
            "Clé USB",
            "Cactus",
            "Coussin",
            "Chaussure solitaire",
            "Tasse de café froide",
            "Post-it collé depuis 2014",
            "Bouteille vide",
            "Bouteille pleine",
            "Bouteille indécise",
            "Sac à dos fatigué",
            "Carton mystérieux",
            "Boîte qui fait peur",
            "Frigo portable",
            "Frigo immobile",
            "Frigo motivé",
            "Frigo dépressif",
            "Micro-ondes philosophe",
            "Grille-pain existentiel",
            "Bouilloire survoltée",
            "Aspirateur grincheux",
            "Ventilateur enthousiaste",
            "Radiateur mélancolique",
            "Machine à laver perplexe",
            "Lave-vaisselle blasé",
            "Poubelle inspirée",
            "Chaise de bureau grinçante",
            "Clavier mécanique bruyant",
            "Souris énervée",
            "Écran trop lumineux",
            "Serveur ronchon",
            "Routeur capricieux",
            "Switch timide",
            "Drone hésitant",
            "Robot aspirateur perdu",
            "Panzer",
            "Panzer un peu trop motivé",
            "Panzer qui n’a rien demandé",
            "Char d’assaut perplexe",
            "Tank introverti",
            "Tank extraverti",
            "Hélicoptère de combat",
            "Hélicoptère de combat pacifiste",
            "Hélicoptère qui tourne en rond",
            "Avion de chasse",
            "Avion de chasse fatigué",
            "Sous-marin distrait",
            "Bateau qui fuit",
            "Fusée ambitieuse",
            "Fusée qui vise la lune",
            "Fusée qui vise la cuisine",
            "Tracteur fier",
            "Tracteur timide",
            "Camion benne rêveur",
            "Voiture électrique stressée",
            "Trottinette en burn-out",
            "Vélo qui grince",
            "Skateboard philosophe",
            "Frigo",
            "Frigo encore",
            "Frigo toujours",
            "Frigo éternel"});
            this.cbQualite.Location = new System.Drawing.Point(10, 52);
            this.cbQualite.Name = "cbQualite";
            this.cbQualite.Size = new System.Drawing.Size(296, 28);
            this.cbQualite.TabIndex = 7;
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.Nom);
            this.gbDetail.Controls.Add(this.tbNom);
            this.gbDetail.Controls.Add(this.Qualité);
            this.gbDetail.Controls.Add(this.cbQualite);
            this.gbDetail.Controls.Add(this.bConfirmer);
            this.gbDetail.Controls.Add(this.bAnnuler);
            this.gbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetail.Location = new System.Drawing.Point(179, 215);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(316, 210);
            this.gbDetail.TabIndex = 8;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Detail personne";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(6, 82);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(44, 20);
            this.Nom.TabIndex = 10;
            this.Nom.Text = "Nom";
            this.Nom.Click += new System.EventHandler(this.Nom_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(10, 105);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(295, 27);
            this.tbNom.TabIndex = 9;
            // 
            // Qualité
            // 
            this.Qualité.AutoSize = true;
            this.Qualité.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qualité.Location = new System.Drawing.Point(6, 29);
            this.Qualité.Name = "Qualité";
            this.Qualité.Size = new System.Drawing.Size(62, 20);
            this.Qualité.TabIndex = 8;
            this.Qualité.Text = "Qualité";
            this.Qualité.Click += new System.EventHandler(this.Qualité_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom de Fichiers";
            // 
            // ofdOuvrir
            // 
            this.ofdOuvrir.FileName = "openFileDialog1";
            // 
            // bModifier
            // 
            this.bModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModifier.Location = new System.Drawing.Point(12, 349);
            this.bModifier.Name = "bModifier";
            this.bModifier.Size = new System.Drawing.Size(145, 35);
            this.bModifier.TabIndex = 10;
            this.bModifier.Text = "Modifier";
            this.bModifier.UseVisualStyleBackColor = true;
            this.bModifier.Click += new System.EventHandler(this.bModifier_Click);
            // 
            // Listes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 441);
            this.Controls.Add(this.bModifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.lbPersonne);
            this.Controls.Add(this.bOuvrir);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.bSupprimer);
            this.Name = "Listes";
            this.Text = "Listes";
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bConfirmer;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.Button bOuvrir;
        private System.Windows.Forms.ListBox lbPersonne;
        private System.Windows.Forms.ComboBox cbQualite;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Label Qualité;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdOuvrir;
        private System.Windows.Forms.SaveFileDialog sfdEnregistrer;
        private System.Windows.Forms.Button bModifier;
    }
}

