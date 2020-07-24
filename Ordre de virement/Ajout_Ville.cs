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
    public partial class Ajout_Ville : Form
    {
        int verification;

        public string Connection = "Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True";
        public Ajout_Ville()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            string req = "insert into Ville values (" + txt_codep.Text + ",'" + txt_ville.Text + "')";
            SqlCommand cmd = new SqlCommand(req, cn);
            MessageBox.Show(req);
            int i = 0 ;
            if (verification==0)
            {
                i = cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Ajout non autorisé changer votre code postal");
            }
            if(i==1)
            {
                MessageBox.Show("Ajout avec succee");
            }
            else
                MessageBox.Show("Echec d'ajout");
            cn.Close();

        }

        private void Ajout_Ville_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void txt_codep_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            string req = "select count(*) from ville where Code_ville=" + txt_codep.Text;
            SqlCommand cmd = new SqlCommand(req, cn);
            //Int32 count = (Int32) (cmd.ExecuteScalar());
            int count;
            if (txt_codep.Text.Length == 0)
                label3.Text = "";


                if (txt_codep.Text.Length>0)
            {
                count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (count == 1)
                {
                    label3.Text = " Existe deja";
                    label3.ForeColor = Color.Red;
                    label3.Visible = true;
                    verification = 1;
                }
                else
                    if(txt_codep.Text.Length!=5)
                {
                    label3.Text = "Format invalide";
                    label3.ForeColor = Color.Red;
                    label3.Visible = true;
                    verification = 1;
                }


                else

                {
                    label3.Visible = false;
                    verification = 0;
                }
            }
            
            cn.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

