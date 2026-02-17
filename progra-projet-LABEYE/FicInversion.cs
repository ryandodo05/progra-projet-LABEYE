using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progra_projet_LABEYE
{
    public partial class FicInversion : Form
    {
        public FicInversion()
        {
            InitializeComponent();

            img1.Left = (this.ClientSize.Width - img1.Width) / 2 - img1.Width / 2; //centrer les deux images par rapport a la taille de la box
            img1.Top = (this.ClientSize.Height - img1.Height) / 2;
            img2.Left = img1.Right + 10;
            img2.Top = img1.Top;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Image temp = img1.Image; // changement entre les deux images
            img1.Image = img2.Image;
            img2.Image = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // ouvrir form 2
            f2.Show();
            this.Hide();
        }
    }
}
