using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class EmployeController : Controller
    {
        List<Employe> listEmploye = new List<Employe>();

        public EmployeController()
        {

        }

        public List<Employe> ListEmploye
        {
            get { return listEmploye; }
        }

        //public void CreerEmploye(string nom, string prenom, string dateNaissance, string adresse, string telResidentiel, int posteTelephonique, string matricule, string categorieEmploi)
        //{
        //    switch (categorieEmploi)
        //    {
        //        case "Chef":
        //            employe = new Chef(nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, matricule, categorieEmploi);
        //            break;
        //        case "Directeur":
        //            employe = new Directeur(nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, matricule, categorieEmploi);
        //            break;
        //        case "Testeur":
        //            employe = new Testeur(nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, matricule, categorieEmploi);
        //            break;
        //        case "Administrateur":
        //            employe = new Administrateur(nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, matricule, categorieEmploi);
        //            break;
        //    }

        //    listEmploye.Add(employe);
        //}

        public override void Insert(params object[] champs)
        {
            Provider.ExecuterCommande("INSERT INTO tblEmploye VALUES (@0, @1, @2, @3, @4, @5, @6)",
                champs[0], champs[1], champs[2], champs[3], champs[4], champs[5], champs[6]);
        }

        public override void Select(string where)
        {
            throw new NotImplementedException();
        }
    }
}
