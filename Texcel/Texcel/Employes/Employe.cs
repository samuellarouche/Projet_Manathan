using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Employe
    {
        string nom, prenom, dateNaissance, adresse, telResidentiel, matricule, categorieEmploi, posteTelephonique, motPasse;

        public Employe(string nom, string prenom, string dateNaissance, string adresse, string telResidentiel, string posteTelephonique, string matricule, string categorieEmploi, string motPasse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.adresse = adresse;
            this.telResidentiel = telResidentiel;
            this.matricule = matricule;
            this.categorieEmploi = categorieEmploi;
            this.posteTelephonique = posteTelephonique;
            this.motPasse = motPasse;
        }

        public string Adresse
        {
            get { return adresse; }
        }

        public string CategorieEmploi
        {
            get { return categorieEmploi;}
        }

        public string DateNaissance
        {
            get { return dateNaissance; }
        }

        public string Matricule
        {
            get { return matricule; }
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Prenom
        {
            get { return prenom; }
        }

        public string TelResidentiel
        {
            get { return telResidentiel; }
        }

        public string PosteTelephonique
        {
            get { return posteTelephonique; }
        }

        public string MotPasse
        {
            get { return motPasse; }
        }

        public override string ToString()
        {
            return prenom + " - " + matricule;
        }
    }
}
