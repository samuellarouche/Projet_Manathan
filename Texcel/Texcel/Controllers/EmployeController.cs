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
        Employe employe;

        public EmployeController()
        {
            Select("");
        }

        public List<Employe> ListEmploye
        {
            get { return listEmploye; }
        }

        //Permet de créer un employé dans la BD.
        public override void Insert(object item)
        {
            employe = (Employe)item;

            Provider.ExecuterCommande("INSERT INTO vueEmploye (matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) VALUES (@0, @1, @2, @3, @4, @5, @6, @7, @8)",
                employe.Matricule, employe.Nom, employe.Prenom, employe.DateNaissance, employe.Adresse, employe.TelResidentiel, employe.PosteTelephonique, employe.CategorieEmploi, employe.MotPasse);

            listEmploye.Add(employe);
        }

        //Permet de récupérer tous les employés de la BD.
        public override void Select(string where)
        {            
            listEmploye.Clear();
            foreach(object[] employeSelectionne in Provider.CommandeLecture("SELECT * FROM vueEmploye " + where))
            {
                employe = new Employe(employeSelectionne[1].ToString(), employeSelectionne[2].ToString(), employeSelectionne[3].ToString(), employeSelectionne[4].ToString(),
                    employeSelectionne[5].ToString(), employeSelectionne[6].ToString(), employeSelectionne[0].ToString(), employeSelectionne[7].ToString(), employeSelectionne[8].ToString());

                listEmploye.Add(employe);
            }
        }

        public override void Delete(string primaryKey)
        {
            Provider.ExecuterCommande("DELETE FROM vueEmploye WHERE matricule = '" + primaryKey + "'");


        }
    }
}
