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
    public partial class Ajout_Type_OP : Form
    {
        public Ajout_Type_OP()
        {
            InitializeComponent();
        }
        public string Connection = "Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True";
        int verification;
        private void txt_codep_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Ajout_Type_OP_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string req_recherche = "select count(*) from type_Operation where nom_type='" + txt_codep.Text + "'";

            string req = "insert into type_Operation values ('" + txt_codep.Text + "')";
            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            SqlCommand cmd_recheche = new SqlCommand(req_recherche, cn);
            int j = (int) cmd_recheche.ExecuteScalar();
            if(j!=1)
            { 
            SqlCommand cmd = new SqlCommand(req, cn);
            int i = cmd.ExecuteNonQuery();
            if(i==1 )
            {
                MessageBox.Show("Ajout avec succee");
            }
            else
            {
                MessageBox.Show("Echec d Ajout ");

            }
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
