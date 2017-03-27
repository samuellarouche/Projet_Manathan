using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Equipe
    {
        string matricule, nomEquipe, codeTest;

        public Equipe(string matricule, string nomEquipe, string codeTest)
        {
            this.matricule = matricule;
            this.nomEquipe = nomEquipe;
            this.codeTest = codeTest;
        }

        public string Matricule
        {
            get { return matricule; }
        }

        public string NomEquipe
        {
            get { return nomEquipe; }
        }

        public string CodeTest
        {
            get { return codeTest; }
        }
    }
}
