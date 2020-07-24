using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ordre_de_virement
{
    public partial class Ajout_Agence : Form
    {
        public string Connection = "Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True";
        public Ajout_Agence()
        {
            InitializeComponent();
        }

        private void Ajout_Agence_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            string req = "select * from Ville ";
            SqlCommand cmd = new SqlCommand(req,cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_ville.Items.Add(dt.Rows[i][1]);
            }
           
               
           
            
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            string req_code = "select  Code_ville from Ville where Nom_ville='" + cmb_ville.Text+"'";
            SqlCommand cmd = new SqlCommand(req_code, cn);
            string  code = cmd.ExecuteScalar().ToString();
           
            string req = "insert into Compte_Banque values ( '"+txt_rib.Text+"',"+code+",'"+txt_nonagence.Text+"')";
            
            cmd = new SqlCommand(req, cn);
            int i = cmd.ExecuteNonQuery();
            if (i==1)
            {
                MessageBox.Show("Ajout effectuer avec succee");
            }
            else
            {
                MessageBox.Show("Echec d'ajout ");
            }
            cn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            string req = "delete from Compte_Banque where Num_Compte='" + txt_rib.Text + "'";
            SqlCommand cmd = new SqlCommand(req,cn);
            DialogResult res = MessageBox.Show("Voulez vous vraiment Supprimer ce Compte ?","Confirmation", MessageBoxButtons.YesNo);
            if(res==DialogResult.Yes)
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Suppression Avec Succée ");
                }
                else
                {
                    MessageBox.Show("Echec de Suppression ");
                }
                

            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
