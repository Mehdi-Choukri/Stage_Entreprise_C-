using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordre_de_virement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_operation());
            //Application.Run(new Beneficiaire());
            //Application.Run(new ORDRE());
            //Application.Run(new Menu());
            //Convertion P = new Convertion();
            //int nb = 100548;
            //Console.WriteLine(P.IntToFr(nb));
            //MessageBox.Show(P.IntToFr(nb));
            Application.Run(new Form_Authentification());
            //Application.Run(new Ajout_Type_OP());


        }



    }
}
