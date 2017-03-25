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
            throw new NotImplementedException();
        }

        public override void Select(string where)
        {
            throw new NotImplementedException();
        }
    }
}
