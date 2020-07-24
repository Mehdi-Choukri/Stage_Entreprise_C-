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
    public partial class Supp_Utilisateur : Form
    {
        public Supp_Utilisateur()
        {
            InitializeComponent();
        }
        public string Connection = "Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True";

        private void Supp_Utilisateur_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Connection);
                cn.Open();
                string req_recherche = "select count(*) from Login_user where Login_ID='" + txt_login.Text + "'";
                SqlCommand cmd_recherche = new SqlCommand(req_recherche, cn);
                int i = (int)cmd_recherche.ExecuteScalar();
                if (i !=0)
                {
                    label2.Visible = false;
                    if (txt_login.Text.Equals(Declaration.user_ID))
                    {
                        label3.Visible = true;
                        label3.ForeColor = Color.Red;
                    }
                    else
                    {
                        label3.Visible = false;
                        
                        string req = "delete Login_user where LTRIM(Login_ID)='" + txt_login.Text + "'";
                        SqlCommand cmd = new SqlCommand(req, cn);
                        int j = cmd.ExecuteNonQuery();
                        if (j == 1)
                        {
                            MessageBox.Show("Utilisateur Supprimer avec succee");
                        }
                        else
                        {
                            MessageBox.Show("Echec de suppression");

                        }
                    }

                }
                else
                {
                    label2.Visible = true;
                    label2.ForeColor = Color.Red;
                }
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }
    }

