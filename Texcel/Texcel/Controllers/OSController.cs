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

        //Vérifie les champs du OS.
        public bool VerifierChampsOS(string champ)
        {
            if ((champ.Length > 0) && (champ.Length <= 50))
                return true;
            else
                return false;
        }

        //Permet de créer un OS dans la BD.
        public override void Insert(params object[] champs)
        {
            Provider.ExecuterCommande("INSERT INTO vueOS (nom, versionOS, codeOS, edition) VALUES(@0, @1, @2, @3);", champs[0], champs[1], champs[2], champs[3]);

            listOS.Add(new OS(champs[0].ToString(), champs[1].ToString(), champs[2].ToString(), champs[3].ToString()));
        }

        //Permet de récupérer tous les OS de la BD.
        public override void Select(string where)
        {
            OS os;

            listOS.Clear();
            foreach (object[] selection in Provider.CommandeLecture("SELECT * FROM vueOS " + where))//Peut-être mettre le where la dedans.
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
