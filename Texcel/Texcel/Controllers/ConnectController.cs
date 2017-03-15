using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class ConnectController : Controller
    {
        public ConnectController()
        {

        }

        public override void Insert(params object[] champs)
        {
            throw new NotImplementedException();
        }

        public override void Select(string where)
        {
            throw new NotImplementedException();
        }

        public bool Connexion(string matricule)
        {
            List<object[]> employe = Provider.CommandeLecture("SELECT * FROM tblEmploye WHERE matricule = '" + matricule + "'");//Pas encore de mot de passe dans la BD.
            if (employe.Count != 0)
                return true;
            else
                return false;
        }
    }
}
