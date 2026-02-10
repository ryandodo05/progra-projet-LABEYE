using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Manipulation_liste
{
    public partial class Listes : Form
    {
        private string NomFichier = "";  // pour les fichiers ouverts/enregistrés
        private int compteurEncodage = 0; // pour générer des encodages uniques

        [DllImport("user32.dll", EntryPoint = "SendMessage")]  // Importation de la fonction SendMessage de l'API Windows
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);  // Déclaration de la fonction SendMessage pour envoyer des messages à une fenêtre
        private const int smLire = 0x0199;  
        private const int smEcrire = 0x019A;
        public Listes()
        {

            InitializeComponent();

        }



        private void Activer(bool actif) //etat actif pour controles
        { // sert à activer ou désactiver les contrôles en fonction de l'état actif

            lbPersonne.Enabled = actif; // gauche 
            bOuvrir.Enabled = actif;
            bEnregistrer.Enabled = actif;
            bAjouter.Enabled = actif;
            bSupprimer.Enabled = actif;
            bModifier.Enabled = actif;

            gbDetail.Enabled = !actif; // droite inversé
        }
        private void EcranListe_Load(object sender, EventArgs e) //chargemet de l'ecran
        {
            cbQualite.Items.AddRange(new string[] // on ajoute la qualité dans la combo box
            {
                // défini directement dans le form via le petit bouton en haut a droite de la box
            });

            Activer(true); //active la partie gauche mais pas la droite
            tbNom.Text = ""; // on vide le nom
            cbQualite.SelectedIndex = -1; // on désélectionne la qualité
        }


        private void Qualité_Click(object sender, EventArgs e)
        {
            // ne pas tenir compte!
        }

        private void Nom_Click(object sender, EventArgs e)
        {
            // ne pas tenir compte!
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            tbNom.Text = "";  // on vide le nom
            cbQualite.SelectedIndex = -1;  // on désélectionne la qualité
            Activer(false); //la gauche se desactive pour activer la droite et reutiliser le formlaire a remplir
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex >= 0)  //pour selectionner dans la liste
                lbPersonne.Items.RemoveAt(lbPersonne.SelectedIndex); //on le RM de la liste
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex < 0) //pour selectionner dans la liste
                return;

            string ligne = lbPersonne.SelectedItem.ToString(); // on recupere la ligne selectionné
            int pos = ligne.LastIndexOf("("); // separer le nom de la qualité en trouvant la position du dernier "("

            tbNom.Text = ligne.Substring(0, pos).Trim(); // on selectionne le nom en prenant ce qui a avant la parenthese et en supprimant les espaces
            cbQualite.Text = ligne.Substring(pos + 1).Replace(")", ""); // on selectionne la qualité en prenant ce qui a après la parenthese et en supprimant les parenthese

            Activer(false);//la gauche se desactive pour activer la droite et reutiliser le formlaire a remplir
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "" || cbQualite.SelectedIndex < 0) // on vérifie que le nom n'est pas vide et qu'une qualité est sélectionnée
                return;

            compteurEncodage++; //genere le compteur d'encodage de litem

            string texte = $"{tbNom.Text} ({cbQualite.SelectedItem})"; // texte qui sera affiché dans la liste, formaté avec le nom et la qualité

            lbPersonne.Items.Add(texte); // on ajoute le texte à la liste

            
            lbPersonne.Sorted = true; // trie alphabéthiquement la liste

            
            int index = lbPersonne.Items.IndexOf(texte); // on trouve l'index de l'item ajouté dans la liste
            SendMessage(lbPersonne.Handle, smEcrire, index, compteurEncodage); // on encode l'item en envoyant un message à la liste avec l'index et le compteur d'encodage

            Activer(true); //la gauche se réactive et la droite se désactive pour revenir à l'état initial de l'interface
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true); //la gauche se réactive et la droite se désactive pour revenir à l'état initial de l'interface
        }

        private void bOuvrir_Click(object sender, EventArgs e) 
        {
            if (ofdOuvrir.ShowDialog() == DialogResult.OK)// on affiche la boite de dialogue d'ouverture de fichier et on vérifie si l'utilisateur a sélectionné un fichier
            {
                NomFichier = ofdOuvrir.FileName; // on stocke le nom du fichier sélectionné dans la variable NomFichier
                lbPersonne.Items.Clear(); // on vide la liste avant de charger les nouvelles données du fichier

                foreach (string ligne in File.ReadAllLines(NomFichier)) // on lit toutes les lignes du fichier et on les ajoute à la liste
                    lbPersonne.Items.Add(ligne); // on ajoute chaque ligne du fichier à la liste
                // a savoir que que je n'ai pas fait d'encodage pour ouverture de fichier car je sais pas comment faire.
            }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                NomFichier = sfdEnregistrer.FileName;

                File.WriteAllLines(NomFichier,
                    lbPersonne.Items.Cast<string>().ToArray());
            }
        }

        private void lbPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex < 0)
                return;

            string texte = lbPersonne.SelectedItem.ToString();
            int index = lbPersonne.SelectedIndex;

            int encodage = SendMessage(lbPersonne.Handle, smLire, index, 0);

            MessageBox.Show(
                $"Texte : {texte}\nIndex : {index}\nEncodage : {encodage}",
                "Informations");
        }

       

    }
}
