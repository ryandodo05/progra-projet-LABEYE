namespace Progress_bar_KRAUS
{
    partial class progressBAR
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
            this.lPrincipal = new System.Windows.Forms.Label();
            this.lSecondaire = new System.Windows.Forms.Label();
            this.pbPrincipal = new System.Windows.Forms.ProgressBar();
            this.pbSecondaire = new System.Windows.Forms.ProgressBar();
            this.bExecuter = new System.Windows.Forms.Button();
            this.bQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lPrincipal
            // 
            this.lPrincipal.AutoSize = true;
            this.lPrincipal.Location = new System.Drawing.Point(65, 68);
            this.lPrincipal.Name = "lPrincipal";
            this.lPrincipal.Size = new System.Drawing.Size(44, 16);
            this.lPrincipal.TabIndex = 0;
            this.lPrincipal.Text = "label1";
            // 
            // lSecondaire
            // 
            this.lSecondaire.AutoSize = true;
            this.lSecondaire.Location = new System.Drawing.Point(64, 114);
            this.lSecondaire.Name = "lSecondaire";
            this.lSecondaire.Size = new System.Drawing.Size(44, 16);
            this.lSecondaire.TabIndex = 1;
            this.lSecondaire.Text = "label2";
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.Location = new System.Drawing.Point(252, 65);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(246, 29);
            this.pbPrincipal.Step = 1;
            this.pbPrincipal.TabIndex = 2;
            // 
            // pbSecondaire
            // 
            this.pbSecondaire.Location = new System.Drawing.Point(252, 114);
            this.pbSecondaire.Name = "pbSecondaire";
            this.pbSecondaire.Size = new System.Drawing.Size(246, 29);
            this.pbSecondaire.Step = 1;
            this.pbSecondaire.TabIndex = 3;
            // 
            // bExecuter
            // 
            this.bExecuter.Location = new System.Drawing.Point(542, 69);
            this.bExecuter.Name = "bExecuter";
            this.bExecuter.Size = new System.Drawing.Size(172, 24);
            this.bExecuter.TabIndex = 4;
            this.bExecuter.Text = "Executer";
            this.bExecuter.UseVisualStyleBackColor = true;
            this.bExecuter.Click += new System.EventHandler(this.bExecuter_Click);
            // 
            // bQuitter
            // 
            this.bQuitter.Location = new System.Drawing.Point(542, 119);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(172, 24);
            this.bQuitter.TabIndex = 5;
            this.bQuitter.Text = "Quitter";
            this.bQuitter.UseVisualStyleBackColor = true;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bExecuter);
            this.Controls.Add(this.pbSecondaire);
            this.Controls.Add(this.pbPrincipal);
            this.Controls.Add(this.lSecondaire);
            this.Controls.Add(this.lPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPrincipal;
        private System.Windows.Forms.Label lSecondaire;
        private System.Windows.Forms.ProgressBar pbPrincipal;
        private System.Windows.Forms.ProgressBar pbSecondaire;
        private System.Windows.Forms.Button bExecuter;
        private System.Windows.Forms.Button bQuitter;
    }
}

