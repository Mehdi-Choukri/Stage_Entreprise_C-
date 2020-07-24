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
    public partial class Ajout_Utilisateur : Form
    {
        public Ajout_Utilisateur()
        {
            InitializeComponent();
        }
        public string Connection = "Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True";

        private void Ajout_Utilisateur_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label6.Visible = false;
            comboBox1.Items.Add("Administrateur");
            comboBox1.Items.Add("Manager");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rang = "";
                if (comboBox1.Text == "Administrateur")
                {
                    rang = "A";
                }
                else
                {
                    rang = "M";
                }

                SqlConnection cn = new SqlConnection(Connection);
                cn.Open();
                string req_recherche = "select count(*) from Login_user where Login_ID='" + txt_login.Text + "'";
                SqlCommand cmd_recherche = new SqlCommand(req_recherche, cn);
                int i = (int)cmd_recherche.ExecuteScalar();
                if (i != 1)
                {
                    label6.Visible = false;
                    if (txt_pw.Text.Equals(txt_cpw.Text))
                    {
                        label4.Visible = false;
                        string req = "insert into Login_user values (' " + txt_login.Text + "','" + txt_pw.Text + "','" + rang + "')";
                        SqlCommand cmd = new SqlCommand(req, cn);
                        int j = cmd.ExecuteNonQuery();
                        if (j == 1)
                        {
                            MessageBox.Show("Utilisateur Ajouter avec succee");
                        }
                        else
                        {
                            MessageBox.Show("Echec d'ajout");

                        }

                    }
                    else
                    {
                        label4.ForeColor = Color.Red;
                        label4.Visible = true;
                    }

                }
                else
                {
                    label6.ForeColor = Color.Red;
                    label6.Visible = true;
                }
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
