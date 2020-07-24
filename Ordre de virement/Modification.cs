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
    public partial class Modification : Form
    {
        string Nom_Doc;
        public string Connection = "Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True";
        public Modification()
        {
            InitializeComponent();
        }
        public void charge_combo_agence()
        {
            string req = "select * from  type_Operation ";
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

        private void Modification_Load(object sender, EventArgs e)
        {
            combo_banque.Items.Clear();
            combo_type_op.Items.Clear();
            charge_combo_agence();

            label_op.Visible = false;
            txt_typeop.Visible = false;

            txt_num_doc.ReadOnly = true;
            txt_montant_lettre.ReadOnly = true;



            string req = "select * from Compte_Banque";

            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand(req, cn);


            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);



            for (int i = 0; i < dt.Rows.Count; i++)
            {

                combo_banque.Items.Add(dt.Rows[i][2]);

            }


            if (Declaration.doc_type != "MAD")
            {

                //txt_ben_moral.Visible = true;

            }
            else
            {


                //label11.Visible = false;
                //txt_rib_ben.Visible = false;
            }



            string req2 = "select * from Document where Num_Document=" + Declaration.Num_doc;

            SqlCommand cmd2 = new SqlCommand(req2, cn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);

            txt_num_doc.Text = dt2.Rows[0][0].ToString();

            txt_note.Text = dt2.Rows[0][1].ToString();

            txt_rib.Text = dt2.Rows[0][2].ToString();
            txt_cin.Text = dt2.Rows[0][3].ToString();
            txt_ben_pc.Text = dt2.Rows[0][4].ToString();
            txt_ben_moral.Text = dt2.Rows[0][5].ToString();
            txt_rib_ben.Text = dt2.Rows[0][6].ToString();
            combo_type_op.Text = dt2.Rows[0][7].ToString();
            date_OP.Text = dt2.Rows[0][8].ToString();

            DateTime now = DateTime.Now;
            string year = now.Year.ToString().Substring(2, 2);/*Ce code va nous permettre de prendre la partie de l'annee apres le 20 */
            Nom_Doc = (int.Parse(dt2.Rows[0][0].ToString()) + 1) + "/" + year;
            txt_montant_chiffre.Text = dt2.Rows[0][9].ToString();

            if (txt_cin.Text.Trim() == "null")
            {
                label6.Visible = false;
                txt_cin.Visible = false;
                txt_ben_pc.Visible = false;
                Declaration.doc_type = "Ordre";
             }
            else
            {
                txt_ben_pc.Visible = true;
                txt_ben_moral.Visible = false;
                Declaration.doc_type = "MAD";
            }
            //if (txt_ben_pc.Text == "null")
            //{
            //    txt_ben_moral.Visible = true;
            //}
            //else
            //{
            //    txt_ben_moral.Visible = false;
            //    txt_ben_pc.Visible = true;
            //}
            //    DateTime D;
            //    D = DateTime.Now;
            //txt_note.Text = "Modifier le " + D;


            cn.Close();



        }

        private void combo_banque_SelectedIndexChanged(object sender, EventArgs e)
        {
            string req = "select * from Compte_Banque where Agence='" + combo_banque.Text + "'";

            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            SqlCommand cmd = new SqlCommand(req, cn);


            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            txt_rib.Text = dt.Rows[0][0].ToString();

            cn.Close();
        }

        private void combo_type_op_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_type_op.Text == "Autre")
            {
                label_op.Show();
                txt_typeop.Show();

            }
            else
            {
                label_op.Hide();
                txt_typeop.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Declaration C = new Declaration();
            txt_montant_lettre.Text = C.IntToFr(int.Parse(txt_montant_chiffre.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Type_operation;
            if (combo_type_op.Text == "Autre")
            {
                Type_operation = txt_typeop.Text;
            }


            else
            {
                Type_operation = combo_type_op.Text;
            }




            if (Declaration.doc_type == "Ordre")
            {
                try
                {
                    string req = "Update Document set Note_Document='" + txt_note.Text + " Modifier le " + DateTime.Now + "  ', Num_Compte ='" + txt_rib.Text + "' ,Nom_Ben_Morale=' " + txt_ben_moral.Text + "' ,RIB_Ben_Morale='" + txt_rib_ben.Text + "', OP_type='" + Type_operation + "', date_doc='" + DateTime.Parse(date_OP.Text).ToString("MM / dd / yyyy") + "' ,doc_montant=" + txt_montant_chiffre.Text + "where Num_Document=" + txt_num_doc.Text;
                    //MessageBoxButtons
                   
                    SqlConnection cn = new SqlConnection(Connection);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(req, cn);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Modification faite avec succee");
                    }
                    else
                    {
                        MessageBox.Show("Echec de Modification");

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                try
                {
                    string req = "Update Document set Note_Document='" + txt_note.Text + " Modifier le " + DateTime.Now + "  ', Num_Compte ='" + txt_rib.Text + "' ,Cin_Ben=' " + txt_cin.Text + "' ,Nom_Ben_PC='" + txt_ben_pc.Text + "', OP_type='" + Type_operation + "', date_doc='" + DateTime.Parse(date_OP.Text).ToString("MM/dd/yyyy") + "' ,doc_montant=" + txt_montant_chiffre.Text + " where Num_Document=" + txt_num_doc.Text;

                    MessageBox.Show(req);
                    SqlConnection cn = new SqlConnection(Connection);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(req, cn);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Modification faite avec succee");
                    }
                    else
                    {
                        MessageBox.Show("Echec de Modification");

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void txt_note_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {
            

            string Type_operation;
            if (combo_type_op.Text == "Autre")
            {
                Type_operation = txt_typeop.Text;
            }


            else
            {
                Type_operation = combo_type_op.Text;
            }

            if (Declaration.doc_type == "Ordre")
            {
                try
                {
                    Impression imp = new Impression();
                    CrystalReport2 C = new CrystalReport2();

                    TextObject t = (TextObject)C.ReportDefinition.Sections[1].ReportObjects["Text3"];
                    t.Text = txt_num_doc.Text;
                    TextObject t1 = (TextObject)C.ReportDefinition.Sections[1].ReportObjects["Text4"];
                    t1.Text = combo_banque.Text;
                    TextObject t2 = (TextObject)C.ReportDefinition.Sections[2].ReportObjects["Text7"];
                    if (combo_type_op.Text != "Autre")
                        t2.Text = combo_type_op.Text;
                    else
                        t2.Text = txt_typeop.Text;
                    string msg = "Virement au compte n° \n " + txt_rib_ben.Text;
                    TextObject t3 = (TextObject)C.ReportDefinition.Sections[2].ReportObjects["Text9"];
                    t3.Text = msg;
                    TextObject t4 = (TextObject)C.ReportDefinition.Sections[2].ReportObjects["Text18"];
                    t4.Text = txt_montant_chiffre.Text;
                    Declaration D = new Declaration();

                    TextObject t5 = (TextObject)C.ReportDefinition.Sections[2].ReportObjects["Text11"];
                    t5.Text = D.IntToFr(int.Parse(txt_montant_chiffre.Text)) + "DIRHAMS";
                    string msg2 = "Messieurs,   Par le débit de notre compte N°" + txt_rib.Text + ", nous vous prions d’effectuer le virement mentionné sous rubrique.";
                    TextObject t6 = (TextObject)C.ReportDefinition.Sections[3].ReportObjects["Text12"];
                    t6.Text = msg2;
                    TextObject t7 = (TextObject)C.ReportDefinition.Sections[3].ReportObjects["Text15"];
                    t7.Text = t2.Text;
                    TextObject t8 = (TextObject)C.ReportDefinition.Sections[3].ReportObjects["Text16"];
                    t8.Text = "C/" + txt_ben_moral.Text;

                    TextObject t9 = (TextObject)C.ReportDefinition.Sections[3].ReportObjects["Text17"];
                    t9.Text = "OIS/H/M/P- 185 DU " + DateTime.Parse(date_OP.Text).ToString("dd / MM / yyyy");
                    imp.crystalReportViewer1.ReportSource = C;
                    imp.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
             
            }
            else
            {
                try { 
                Impression imp = new Impression();
                Crysta_MAD CM = new Crysta_MAD();
                Declaration C = new Declaration();
                TextObject t = (TextObject)CM.ReportDefinition.Sections[1].ReportObjects["Text3"];
                t.Text = Nom_Doc;
                TextObject t1 = (TextObject)CM.ReportDefinition.Sections[1].ReportObjects["Text4"];
                t1.Text = combo_banque.Text;
                TextObject t2 = (TextObject)CM.ReportDefinition.Sections[1].ReportObjects["Text8"];
                t2.Text = "Par prélèvement sur notre compte n° " + txt_rib.Text + ", \n" + "nous vous prions de mettre à la disposition de \n " + txt_ben_pc.Text + "(C.I.N. n°" + txt_cin.Text + "),";
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

        }
    }
}
