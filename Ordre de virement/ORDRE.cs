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
using CrystalDecisions.CrystalReports.Engine;

namespace Ordre_de_virement
{
    public partial class ORDRE : Form
    {

        public string Connection = "Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True";
        public ORDRE()
        {
            InitializeComponent();
        }
        public string Num_DOC_AN;
        public void charge_combo_agence ()
        {
            string req = "select * from  type_Operation " ;
            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand(req, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                combo_type_op.Items.Add(dt.Rows[i][0].ToString());
            }
            cn.Close();
        }
        public int combo_valeur (string nom_agence )
        {
            string req = "select id_type from  type_Operation where nom_type=" + nom_agence;
            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand(req, cn);
            int S = (int) cmd.ExecuteScalar();


            return S;
        }

        private void MAD_Load(object sender, EventArgs e)
        {
            label_op.Hide();
            typeop_zone.Hide();
            combo_type_op.Items.Clear();
            charge_combo_agence();
            txt_num_doc.ReadOnly = true;



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
         
            
            string req2 = "select top 1 * from Document order by Num_Document desc ";
            SqlCommand cmd2 = new SqlCommand(req2, cn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);

            DateTime now = DateTime.Now;
            string year = now.Year.ToString().Substring(2, 2);/*Ce code va nous permettre de prendre la partie de l'annee apres le 20 */
             
            
            Num_DOC_AN = (int.Parse(dt2.Rows[0][0].ToString()) + 1) + "/" + year;
            txt_num_doc.Text = (int.Parse(dt2.Rows[0][0].ToString()) + 1) + "";



            cn.Close();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void combo_type_op_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_type_op.Text == "Autre")
            {
                label_op.Show();
                typeop_zone.Show();

            }
            else
            {
                label_op.Hide();
                typeop_zone.Hide();
            }
        }

        private void combo_banque_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            string req = "select * from Compte_Banque where Agence='" + combo_banque.Text + "'";

            SqlCommand cmd = new SqlCommand(req, cn);

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            txt_rib.Text = dt.Rows[0][0].ToString();
            
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Declaration C = new Declaration();
            txt_montant_lettre.Text=C.IntToFr(int.Parse(txt_montant_chiffre.Text));

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




                ps1.Value = int.Parse(txt_num_doc.Text);
                if (txt_note.Text.Length == 0)
                {
                    ps2.Value = "null";
                }
                else
                {
                    ps2.Value = txt_note.Text;
                }

                ps4.Value = txt_rib.Text;
                if(txt_cin.Text.Length>4)
                {
                    ps5.Value = txt_cin.Text;
                    ps6.Value = txt_nom_ben.Text;
                    ps7.Value = "null";

                }
                else
                {
                    ps6.Value = "null";
                    ps5.Value = "null";
                    ps7.Value = txt_nom_ben.Text;
                }
               
               
                ps8.Value = txt_rib_ben.Text;

                ps9.Value = DateTime.Parse(date_OP.Text).ToString("dd / MM / yyyy");

                ps10.Value = float.Parse(txt_montant_chiffre.Text);
                if (combo_type_op.Text == "Autre")
                {


                    ps11.Value = combo_type_op.Text;
                }
                else
                {
                    ps11.Value = combo_type_op.Text;
                }
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Impression imp = new Impression();
            CrystalReport2 C = new CrystalReport2();

            TextObject t = (TextObject)C.ReportDefinition.Sections[1].ReportObjects["Text3"];
            t.Text = Num_DOC_AN;
            TextObject t1 = (TextObject)C.ReportDefinition.Sections[1].ReportObjects["Text4"];
            t1.Text = combo_banque.Text;
            TextObject t2 = (TextObject)C.ReportDefinition.Sections[2].ReportObjects["Text7"];
            if(combo_type_op.Text!="Autre")
            t2.Text = combo_type_op.Text;
            else
                t2.Text = typeop_zone.Text;
            string msg = "Virement au compte n° \n " + txt_rib_ben.Text;
            TextObject t3 = (TextObject)C.ReportDefinition.Sections[2].ReportObjects["Text9"];
            t3.Text = msg;
            TextObject t4 = (TextObject)C.ReportDefinition.Sections[2].ReportObjects["Text18"];
            t4.Text = txt_montant_chiffre.Text;
            Declaration D = new Declaration();
            
            TextObject t5 = (TextObject)C.ReportDefinition.Sections[2].ReportObjects["Text11"];
            t5.Text = D.IntToFr(int.Parse(txt_montant_chiffre.Text)) + "DIRHAMS";
            string msg2 = "Messieurs,   Par le débit de notre compte N°"+txt_rib.Text+", nous vous prions d’effectuer le virement mentionné sous rubrique.";
            TextObject t6 = (TextObject)C.ReportDefinition.Sections[3].ReportObjects["Text12"];
            t6.Text = msg2;
            TextObject t7 = (TextObject)C.ReportDefinition.Sections[3].ReportObjects["Text15"];
            t7.Text = t2.Text;
            TextObject t8 = (TextObject)C.ReportDefinition.Sections[3].ReportObjects["Text16"];
            t8.Text = "C/" + txt_nom_ben.Text;

            TextObject t9 = (TextObject)C.ReportDefinition.Sections[3].ReportObjects["Text17"];
            t9.Text = "OIS/H/M/P- 185 DU " + DateTime.Parse(date_OP.Text).ToString("dd / MM / yyyy");
            imp.crystalReportViewer1.ReportSource = C;
            imp.Show();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
