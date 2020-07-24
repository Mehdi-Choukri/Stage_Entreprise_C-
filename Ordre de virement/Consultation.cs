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
using System.Data;
using CrystalDecisions.CrystalReports.Engine;


namespace Ordre_de_virement
{
    public partial class Consultation : Form
    {
        public string Connection = "Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True";
        public Consultation()
        {
            InitializeComponent();
        }
        //public string Imprime(int N , string note , string num_cmpt , string CIN , string ben_pc , string )
        //{
        //    string lettre = "";

        //    return; 
        //}

            public void Ajout_Column_Impression ()
        {
           if(dataGridView1.Columns.Count==10)
            {
                DataGridViewButtonColumn btn_M = new DataGridViewButtonColumn();
                btn_M.Name = "Consulter";
                btn_M.Text = "Consulter";
                btn_M.UseColumnTextForButtonValue = true;

              

                dataGridView1.Columns.AddRange(btn_M);
            }
          

        }
        private void Consultation_Load(object sender, EventArgs e)
        {
            combo_consultation.Items.Clear();
            combo_consultation.Items.Add("N° Document");
            combo_consultation.Items.Add("Nom");
            combo_consultation.Items.Add("CIN");
            combo_consultation.Items.Add("Nom Societé");
            combo_consultation.Items.Add("Tous les documents");
           



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.ColumnIndex != 10 )
            {
                return;
            }

            ////else
            ////{

            ////DataGridViewButtonCell bc = new DataGridViewButtonCell();
            ////bc = dataGridView1.CurrentRow.Cells[10] as DataGridViewButtonCell;
            //if (dataGridView1.CurrentRow.Cells[0].Value.ToString()=="Imprimer")



            Declaration.Num_doc = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Modification m = new Modification();

            m.Show();




            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
           try
            {
                SqlConnection cn = new SqlConnection(Connection);
                cn.Open();
                string choix = "";
                string req = "";
                if (combo_consultation.Text == "CIN")

                {
                    choix = "CIN_Ben";

                    req = "select * from Document where  " + choix + "='" + txt_cible.Text + "'";


                }
                else
                {
                    if (combo_consultation.Text == "Nom")
                    {
                        choix = "Nom_Ben_PC";

                        req = "select * from Document where  " + choix + " Like '%" + txt_cible.Text + "%' ";
                    }
                    else

                    if (combo_consultation.Text == "N° Document")
                    {
                        choix = "Num_Document";
                        req = "select * from Document where  " + choix + "=" + txt_cible.Text + "";
                    }
                    else

                    if (combo_consultation.Text == "Nom Societé")
                    {
                        choix = "Nom_Ben_Morale";
                        req = "select * from Document where  " + choix + " Like '%" + txt_cible.Text + "%'";
                    }
                    else

                    if (combo_consultation.Text == "Tous les documents")
                    {

                        req = "select * from Document";
                    }
                }



                SqlCommand cmd = new SqlCommand(req, cn);
                //MessageBox.Show(req);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);



                if ((dt.Rows[0][3].ToString().Length == 0) || (dt.Rows[0][3].ToString() == "null"))
                {
                    Declaration.doc_type = "Ordre";
                }
                else
                {
                    Declaration.doc_type = "MAD";
                }
                Declaration.Num_doc = int.Parse(dt.Rows[0][0].ToString());

                dataGridView1.DataSource = dt;
                Ajout_Column_Impression();

                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void combo_consultation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Connection);
                string req = "select * from Document where Num_Document=" + txt_cible.Text;
                cn.Open();
                SqlCommand cmd = new SqlCommand(req, cn);

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);



                if ((dt.Rows[0][3].ToString().Length == 0) || (dt.Rows[0][3].ToString() == "null"))
                {
                    Declaration.doc_type = "Ordre";
                }
                else
                {
                    Declaration.doc_type = "MAD";
                }
                Declaration.Num_doc = int.Parse(txt_cible.Text);
                cn.Close();
                Modification md = new Modification();
                md.Show();
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





