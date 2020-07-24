using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ordre_de_virement
{
    class Acces_aux_donnees
    {

        private SqlConnection connection;
        private SqlCommand cmd;
        private string chaine = "Data Source=MARSHALDTEACH;Initial Catalog=OCPAPP;Integrated Security=True";

        /*Ouverture de la connection */
        public void Ouvrir()
        {
            if(connection.State==ConnectionState.Closed || connection.State == ConnectionState.Broken )
            {
                connection = new SqlConnection(chaine);
                connection.Open();
            }
        }

        /*fermeture de la connection */
        public void Fermer()
        {
            if (connection.State == ConnectionState.Open )
            {
                connection.Close();
            }
        }

        
        

        public int Action(String req)
        {
            cmd = new SqlCommand(req, connection);

            return cmd.ExecuteNonQuery();
        }

       
        public DataTable Charger(string req)
        {
            cmd = new SqlCommand(req, connection);
            SqlDataReader DR = cmd.ExecuteReader();
            DataTable Dt = new DataTable();
            Dt.Load(DR);
            return Dt;
        }

    }
}
