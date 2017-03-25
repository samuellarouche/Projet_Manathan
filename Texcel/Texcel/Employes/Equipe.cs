using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Equipe
    {
        string matricule, nomEquipe, projetTest;

        public Equipe(string matricule, string nomEquipe, string projetTest)
        {
            this.matricule = matricule;
            this.nomEquipe = nomEquipe;
            this.projetTest = projetTest;
        }

        public string Matricule
        {
            get { return matricule; }
        }

        public string NomEquipe
        {
            get { return nomEquipe; }
        }

        public string ProjetTest
        {
            get { return projetTest; }
        }
    }
}
