namespace progra_projet_LABEYE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Location = new System.Drawing.Point(455, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 66);
            this.button2.TabIndex = 7;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(111, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "switch img";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // img2
            // 
            this.img2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img2.BackgroundImage")));
            this.img2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img2.Location = new System.Drawing.Point(369, 50);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(322, 162);
            this.img2.TabIndex = 5;
            this.img2.TabStop = false;
            this.img2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // img1
            // 
            this.img1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img1.BackgroundImage")));
            this.img1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img1.Location = new System.Drawing.Point(37, 50);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(299, 161);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 4;
            this.img1.TabStop = false;
            this.img1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 325);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img1;
    }
}

