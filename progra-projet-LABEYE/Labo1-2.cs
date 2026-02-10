using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progra_projet_LABEYE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "quitter ?", // message pour quitter
                "Confirmer",
                MessageBoxButtons.YesNo, // ui non
                MessageBoxIcon.Question // icon question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true; // stopper close
            }
        }
    }
}