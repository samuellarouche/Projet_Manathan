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
        
        public override string Insert()
        {
            return Provider.ExecuterCommande("INSERT INTO Region VALUES(@0, @1);", 10, "Tronc");
        }

        //Permet de créer un OS dans la BD.
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
