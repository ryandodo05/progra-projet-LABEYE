using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_bar_KRAUS
{
    public partial class progressBAR : Form
    {
        public progressBAR()
        {
            InitializeComponent();
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void bExecuter_Click(object sender, EventArgs e)
        {
            bExecuter.Enabled = false; // on désactive le bouton pour éviter les clics intempestifs
            bQuitter.Enabled = false;// on désactive le bouton pour éviter les clics intempestifs
            Cursor = Cursors.WaitCursor; // metre un curseur attente 

            Random rnd = new Random(); //histoire d'avoir un nombre de fichier aléatoire
            int nbFichiers = rnd.Next(5, 15);

            pbPrincipal.Minimum = 0; //la barrre a 0
            pbPrincipal.Maximum = nbFichiers; // le max
            pbPrincipal.Value = 0;

            for (int i = 0; i < nbFichiers; i++)// pour chaque fichier
            {
                lPrincipal.Text = $"Copie du fichier {i + 1}/{nbFichiers}";//numero du fichier en cours de copie
                lPrincipal.Refresh();// pour forcer le rafraichissement de l'affichage

                int taille = rnd.Next(20, 100);//une taille pour le realisme de la copie

                pbSecondaire.Minimum = 0;
                pbSecondaire.Maximum = taille;
                pbSecondaire.Value = 0;

                for (int j = 0; j < taille; j++)// pour chaque unité de copie
                {
                    pbSecondaire.Value++;// on avance la barre secondaire
                    await Task.Delay(20); // version non bloquante
                }

                pbPrincipal.Value++;// on avance la barre principale
            }

            Cursor = Cursors.Default;
            bExecuter.Enabled = true;// on réactive les bouttons
            bQuitter.Enabled = true;
        }
    }
}

