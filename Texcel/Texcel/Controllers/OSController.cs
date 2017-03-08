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

        }

        //Permet de créer un OS dans la BD.
        public override void Insert(params string[] champs)
        {
            Provider.ExecuterCommande("INSERT INTO tblOS VALUES(@0, @1, @2, @3);", champs[0], champs[1], champs[2], champs[3]);
        }

        //Permet de récupérer tous les OS de la BD.
        public override void Select()
        {
            foreach(object os in Provider.CommandeLecture("SELECT * FROM Shippers"))
            {
                //listOS.Add((OS)os);
            }
        }

        public void CreerOS(string nom, string version, string code, string edition)
        {           
            os = new OS(nom, version, code, edition);
            listOS.Add(os);
        }

        public List<OS> ListOS
        {
            get { return listOS; }
        }
    }
}
