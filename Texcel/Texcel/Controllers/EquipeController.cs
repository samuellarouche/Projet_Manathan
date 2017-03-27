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
		Equipe equipe;
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
			equipe = (Equipe)item;
			Provider.ExecuterCommande("INSERT INTO vueEquipe (nomEquipe, nomTest, Employe1, Employe2, Employe3, Employe4, Employe5) VALUES (@0, @1, @2, @3, @4, @5, @6)",
			equipe.NomEquipe, equipe.NomTest, equipe.Matricule1, equipe.Matricule2, equipe.Matricule3, equipe.Matricule4, equipe.Matricule5);

			listEquipe.Add(equipe);
        }

        public override void Select(string where)
        {
            throw new NotImplementedException();
        }
    }
}
