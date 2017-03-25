using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Testeur : Employe
    {
        public Testeur(string nom, string prenom, string dateNaissance, string adresse, string telResidentiel, string posteTelephonique, string matricule, string categorieEmploi, string motPasse) : base(nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, matricule, categorieEmploi, motPasse)
        {
        }
    }
}
