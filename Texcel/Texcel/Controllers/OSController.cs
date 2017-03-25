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
        OS os;

        public OSController() : base()
        {
            Select("");
        }

        //Permet de créer un OS dans la BD.
        public override void Insert(object item)
        {
            os = (OS)item;

            Provider.ExecuterCommande("INSERT INTO vueOS (nom, versionOS, codeOS, edition) VALUES(@0, @1, @2, @3);", os.Nom, os.Version, os.Code, os.Edition);

            listOS.Add(os);
        }

        //Permet de récupérer tous les OS de la BD.
        public override void Select(string where)
        {
            listOS.Clear();
            foreach (object[] selection in Provider.CommandeLecture("SELECT * FROM vueOS " + where))
            {
                os = new OS(selection[0].ToString(), selection[1].ToString(), selection[2].ToString(), selection[3].ToString());
                listOS.Add(os);
            }
        }

        //Supprime un OS de la BD et de la liste.
        public override void Delete(string codeOS)
        {
            Provider.ExecuterCommande("DELETE FROM vueOS WHERE codeOS = '" + codeOS + "'");

            //ListOS.RemoveAt(index);
        }

        public List<OS> ListOS
        {
            get { return listOS; }
        }
    }
}
