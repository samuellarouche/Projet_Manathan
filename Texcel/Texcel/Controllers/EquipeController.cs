using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class EquipeController : Controller
    {
        List<Equipe> listEquipe = new List<Equipe>();

        public EquipeController()
        {

        }

        public List<Equipe> ListEquipe
        {
            get { return listEquipe; }
        }

        public override void Delete(string where)
        {
            throw new NotImplementedException();
        }

        public override void Insert(object item)
        {
            Provider.ExecuterCommande("INSERT INTO vueEquipe (nomEquipe, Employe1, Employe2, Employe3, Employe4, Employe5) VALUES ()")
        }

        public override void Select(string where)
        {
            throw new NotImplementedException();
        }
    }
}
