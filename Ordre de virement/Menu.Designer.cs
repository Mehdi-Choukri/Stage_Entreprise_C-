namespace Ordre_de_virement
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordreDeVirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseADispositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.villeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeDoperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.insertionToolStripMenuItem,
            this.utilisateursToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 20);
            this.toolStripMenuItem1.Text = "Nature de document";
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordreDeVirementToolStripMenuItem,
            this.miseADispositionToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // ordreDeVirementToolStripMenuItem
            // 
            this.ordreDeVirementToolStripMenuItem.Name = "ordreDeVirementToolStripMenuItem";
            this.ordreDeVirementToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ordreDeVirementToolStripMenuItem.Text = "Ordre de Virement";
            this.ordreDeVirementToolStripMenuItem.Click += new System.EventHandler(this.ordreDeVirementToolStripMenuItem_Click);
            // 
            // miseADispositionToolStripMenuItem
            // 
            this.miseADispositionToolStripMenuItem.Name = "miseADispositionToolStripMenuItem";
            this.miseADispositionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.miseADispositionToolStripMenuItem.Text = "Mise a Disposition";
            this.miseADispositionToolStripMenuItem.Click += new System.EventHandler(this.miseADispositionToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // insertionToolStripMenuItem
            // 
            this.insertionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.villeToolStripMenuItem,
            this.agenceToolStripMenuItem,
            this.typeDoperationToolStripMenuItem});
            this.insertionToolStripMenuItem.Name = "insertionToolStripMenuItem";
            this.insertionToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.insertionToolStripMenuItem.Text = "Insertion";
            // 
            // villeToolStripMenuItem
            // 
            this.villeToolStripMenuItem.Name = "villeToolStripMenuItem";
            this.villeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.villeToolStripMenuItem.Text = "Ville";
            this.villeToolStripMenuItem.Click += new System.EventHandler(this.villeToolStripMenuItem_Click);
            // 
            // agenceToolStripMenuItem
            // 
            this.agenceToolStripMenuItem.Name = "agenceToolStripMenuItem";
            this.agenceToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.agenceToolStripMenuItem.Text = "Agence";
            this.agenceToolStripMenuItem.Click += new System.EventHandler(this.agenceToolStripMenuItem_Click);
            // 
            // typeDoperationToolStripMenuItem
            // 
            this.typeDoperationToolStripMenuItem.Name = "typeDoperationToolStripMenuItem";
            this.typeDoperationToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.typeDoperationToolStripMenuItem.Text = "Type d\'operation";
            this.typeDoperationToolStripMenuItem.Click += new System.EventHandler(this.typeDoperationToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            this.ajoutToolStripMenuItem.Click += new System.EventHandler(this.ajoutToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ordre_de_virement.Properties.Resources.comptabilite;
            this.pictureBox1.Location = new System.Drawing.Point(27, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 371);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordreDeVirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseADispositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem villeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeDoperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}