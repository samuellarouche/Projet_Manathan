using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class EmployeController
    {
        List<Employe> listEmploye = new List<Employe>();
        Employe employe;

        public EmployeController()
        {

        }

        public void CreerEmploye(string nom, string prenom, string dateNaissance, string adresse, string telResidentiel, int posteTelephonique, string matricule, string categorieEmploi)
        {
            switch (categorieEmploi)
            {
                case "Chef":
                    employe = new Chef(nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, matricule, categorieEmploi);
                    break;
                case "Directeur":
                    employe = new Directeur(nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, matricule, categorieEmploi);
                    break;
                case "Testeur":
                    employe = new Testeur(nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, matricule, categorieEmploi);
                    break;
                case "Administrateur":
                    employe = new Administrateur(nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, matricule, categorieEmploi);
                    break;
            }

            listEmploye.Add(employe);
        }

        public List<Employe> ListEmploye
        {
            get { return listEmploye; }
        }
    }
}
