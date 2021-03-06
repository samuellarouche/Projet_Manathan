﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Employe
    {
        string nom, prenom, dateNaissance, adresse, telResidentiel, matricule, categorieEmploi, posteTelephonique;//Doit avoir un mot de passe.

        public Employe(string nom, string prenom, string dateNaissance, string adresse, string telResidentiel, string posteTelephonique, string matricule, string categorieEmploi)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.adresse = adresse;
            this.telResidentiel = telResidentiel;
            this.matricule = matricule;
            this.categorieEmploi = categorieEmploi;
            this.posteTelephonique = posteTelephonique;
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
    }
}
