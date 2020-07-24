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
    public partial class MAD : Form

    {
        string Nom_Doc;
        public string Connection = "Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True";
        public MAD()
        {
            InitializeComponent();
        }
        //public void charge_combo_Type()
        //{
        //    string req = "select * from  type_Operation ";
        //    SqlConnection cn = new SqlConnection(Connection);
        //    cn.Open();
        //    SqlCommand cmd = new SqlCommand(req, cn);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(dr);
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        combo_type_op.Items.Add(dt.Rows[i][0].ToString());
        //    }
        //    cn.Close();
        //}
        //public int combo_valeur(string nom_agence)
        //{
        //    string req = "select id_type from  type_Operation where nom_type=" + nom_agence;
        //    SqlConnection cn = new SqlConnection(Connection);
        //    cn.Open();
        //    SqlCommand cmd = new SqlCommand(req, cn);
        //    int S = (int)cmd.ExecuteScalar();


        //    return S;
        //}
        

        private void combo_banque_SelectedIndexChanged(object sender, EventArgs e)
        {

            string req = "select * from Compte_Banque where Agence='" + combo_banque.Text + "'";

            SqlConnection cn = new SqlConnection("Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(req, cn);

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            txt_rib.Text = dt.Rows[0][0].ToString();
           
        }

        private void MAD_Load(object sender, EventArgs e)
        {
            combo_banque.Items.Clear();
           
            combo_type_op.Text = "Mise à disposition";


            txt_montant_lettre.ReadOnly = true;
            txt_num.ReadOnly = true;

            /*Chargement du combo type_operation */




            string req = "select * from Compte_Banque";

            SqlConnection cn = new SqlConnection("Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(req, cn);


            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);



            for (int i = 0; i < dt.Rows.Count; i++)
            {

                combo_banque.Items.Add(dt.Rows[i][2]);

            }

            /* requete qui charge la zone de texte avec le dernier enregistrement inseré dans la table */
            string req2 = "select top 1 * from Document order by Num_Document desc ";
            SqlCommand cmd2 = new SqlCommand(req2, cn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);

            DateTime now = DateTime.Now;
            string year = now.Year.ToString().Substring(2, 2);/*Ce code va nous permettre de prendre la partie de l'annee apres le 20 */
        

             Nom_Doc = (int.Parse(dt2.Rows[0][0].ToString()) + 1) + "/" + year;
            txt_num.Text = (int.Parse(dt2.Rows[0][0].ToString()) + 1) + "";



            cn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_ben_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Declaration C = new Declaration();
            txt_montant_lettre.Text = C.IntToFr(int.Parse(txt_montant_chiffre.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                

                SqlConnection cnx = new SqlConnection(Connection);
                cnx.Open();
                DateTime d;
                d = DateTime.Now;

                string req2 = "PS_ajouter_Document";
                SqlCommand cmd2 = new SqlCommand(req2, cnx);

                cmd2.CommandType = CommandType.StoredProcedure;
                SqlParameter ps1 = cmd2.Parameters.Add("@P_NUM", SqlDbType.Int);
                SqlParameter ps2 = cmd2.Parameters.Add("@P_NOTE", SqlDbType.Text);

                SqlParameter ps4 = cmd2.Parameters.Add("@P_NUMCMPT", SqlDbType.VarChar, 24);
                SqlParameter ps5 = cmd2.Parameters.Add("@P_CIN ", SqlDbType.VarChar, 10);
                SqlParameter ps6 = cmd2.Parameters.Add("@P_NOM_PC", SqlDbType.Char, 50);
                SqlParameter ps7 = cmd2.Parameters.Add("@P_NOM_MORALE", SqlDbType.Char, 50);
                SqlParameter ps8 = cmd2.Parameters.Add("@P_RIB", SqlDbType.Char, 24);
                SqlParameter ps9 = cmd2.Parameters.Add("@P_DATEOP", SqlDbType.Date);
                SqlParameter ps10 = cmd2.Parameters.Add("@P_MONTANTOP", SqlDbType.Float);
                SqlParameter ps11 = cmd2.Parameters.Add("@P_TYPEOP", SqlDbType.VarChar, 50);
                SqlParameter ps12 = cmd2.Parameters.Add("@p_etat", SqlDbType.Char, 50);


               

                ps1.Value = int.Parse(txt_num.Text);
                if (txt_note.Text.Length == 0)
                {
                    ps2.Value = "null";
                }
                else
                {
                    ps2.Value = txt_note.Text;
                }

                ps4.Value = txt_rib.Text;
                ps5.Value = txt_cin.Text;
                ps6.Value = txt_ben.Text;
                ps7.Value = "null";
                ps8.Value = "null";
                ps9.Value = DateTime.Parse(date_op.Text).ToString("dd / MM / yyyy");

                ps10.Value = float.Parse(txt_montant_chiffre.Text);
                
                    ps11.Value = combo_type_op.Text;
                
                ps12.Direction = ParameterDirection.Output;



                int i = cmd2.ExecuteNonQuery();
                if (i == 1)
                {

                    MessageBox.Show("Ajout avec succee");
                }
                else
                {
                    MessageBox.Show("Echec d ajout ");

                }
                cnx.Close();
                DateTime now = DateTime.Now;
                string year = now.Year.ToString().Substring(2, 2);/*Ce code va nous permettre de prendre la partie de l'annee apres le 20 */
                
                Impression imp = new Impression();
                Crysta_MAD CM = new Crysta_MAD();
                Declaration C = new Declaration();
                TextObject t = (TextObject)CM.ReportDefinition.Sections[1].ReportObjects["Text3"];
                t.Text = Nom_Doc;
                TextObject t1 = (TextObject)CM.ReportDefinition.Sections[1].ReportObjects["Text4"];
                t1.Text = combo_banque.Text;
                TextObject t2 = (TextObject)CM.ReportDefinition.Sections[1].ReportObjects["Text8"];
                t2.Text = "Par prélèvement sur notre compte n° " + txt_rib.Text + ", \n" + "nous vous prions de mettre à la disposition de \n " + txt_ben.Text + "(C.I.N. n°" + txt_cin.Text + "),";
                TextObject t3 = (TextObject)CM.ReportDefinition.Sections[1].ReportObjects["Text9"];
                t3.Text = "La somme de " + txt_montant_chiffre.Text + " DH (" + C.IntToFr(int.Parse(txt_montant_chiffre.Text)) + ").";
                imp.crystalReportViewer1.ReportSource = CM;
                imp.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           







        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combo_type_op_SelectedIndexChanged(object sender, EventArgs e)
        {
           

                
           
        }
    }
}
