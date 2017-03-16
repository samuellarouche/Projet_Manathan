using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class OSController : Controller
    {
        List<OS> listOS = new List<OS>();

        public OSController() : base()
        {
            Select("");
        }

        //Permet de créer un OS dans la BD.
        public override void Insert(params object[] champs)
        {
            Provider.ExecuterCommande("INSERT INTO tblOS VALUES(@0, @1, @2, @3);", champs[0], champs[1], champs[2], champs[3]);
            //Ajouter le OS dans la liste de OS.s
        }

        //Permet de récupérer tous les OS de la BD.
        public override void Select(string where)
        {
            OS os;

            listOS.Clear();
            foreach (object[] selection in Provider.CommandeLecture("SELECT * FROM tblOS " + where))//Peut-être mettre le where la dedans.
            {
                os = new OS(selection[0].ToString(), selection[1].ToString(), selection[2].ToString(), selection[3].ToString());
                listOS.Add(os);
            }
        }

        public List<OS> ListOS
        {
            get { return listOS; }
        }
    }
}
