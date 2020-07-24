using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordre_de_virement
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private static bool _exiting;
        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultation c = new Consultation();
            c.Show();
        }

        private void ordreDeVirementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ORDRE O = new ORDRE();
            O.Show();
        }

        private void miseADispositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAD m = new MAD();
            m.Show();
        }

        private void villeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Ville AV = new Ajout_Ville();
            AV.Show();
        }

        private void agenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Agence AA = new Ajout_Agence();
            AA.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(Declaration.user_rang=="A")
            {
                insertionToolStripMenuItem.Visible = false;
                agenceToolStripMenuItem.Visible = false;
                typeDoperationToolStripMenuItem.Visible = false;
                miseADispositionToolStripMenuItem.Visible = false;
                ordreDeVirementToolStripMenuItem.Visible = false;
                consultationToolStripMenuItem.Visible = false;
                toolStripMenuItem1.Visible = false;
            }
            else
            {
                utilisateursToolStripMenuItem.Visible = false;
            }
        }

        private void typeDoperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Type_OP AJT = new Ajout_Type_OP();
            AJT.Show();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_exiting && MessageBox.Show("Voulez vous vraiment quitter l'application?",
                       "OCP APP",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;
                
                Environment.Exit(1);
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_exiting && MessageBox.Show("Voulez vous vraiment quitter l'application?",
                       "OCP APP",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;

                Environment.Exit(1);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_Utilisateur AU = new Ajout_Utilisateur();
            AU.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supp_Utilisateur SU = new Supp_Utilisateur();
            SU.Show();
            
        }
    }
}
