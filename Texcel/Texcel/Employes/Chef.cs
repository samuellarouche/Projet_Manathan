using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Chef : Employe
    {
        public Chef(string nom, string prenom, string dateNaissance, string adresse, string telResidentiel, int posteTelephonique, string matricule, string categorieEmploi) : base(nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, matricule, categorieEmploi)
        {
        }
    }
}
