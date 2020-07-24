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
    public partial class Form_Authentification : Form
    {
        public string Connection = "Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True";

        public Form_Authentification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string req = "select * from Login_user";
            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand(req, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            bool trouve = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i][0].Equals(txt_login.Text) && dt.Rows[i][1].Equals(txt_pw.Text))
                {
                    trouve = true;
                    Declaration.user_ID = dt.Rows[i][0].ToString();
                    Declaration.user_rang = dt.Rows[i][2].ToString();
                    break;
                }

            }
            if(trouve==true)
            {
                
                MessageBox.Show("Authentification avec succee ");
                
                Menu M = new Menu();
                M.Show();
                this.Hide();
            
             }
            else
            {
                MessageBox.Show("Id ou mot de passe incorrect");
            }
            cn.Close();
        }

        private void Form_Authentification_Load(object sender, EventArgs e)
        {

        }
    }
}
