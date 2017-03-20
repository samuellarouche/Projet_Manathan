using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Equipe
    {
        string matricule, nomEquipe, tache;

        public Equipe(string matricule, string nomEquipe, string tache)
        {
            this.matricule = matricule;
            this.nomEquipe = nomEquipe;
            this.tache = tache;
        }

        public string Matricule
        {
            get { return matricule; }
        }

        public string NomEquipe
        {
            get { return nomEquipe; }
        }

        public string Tache
        {
            get { return tache; }
        }
    }
}
