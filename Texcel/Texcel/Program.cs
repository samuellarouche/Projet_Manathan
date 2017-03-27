//Francis Poirier et Samuel Larouche
//
//Programme qui simule la gestion de projets de tests
//et d'employés à l'aide d'une BD.
//
//26/03/2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texcel
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConnexion());
        }
    }
}
