using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Equipe
    {
		string matricule1, matricule2, matricule3, matricule4, matricule5, nomEquipe, nomTest;

        public Equipe(string nomEquipe, string nomTest, string matricule1, string matricule2, string matricule3, string matricule4, string matricule5)
        {

            this.matricule1 = matricule1;
			this.matricule2 = matricule2;
			this.matricule3 = matricule3;
			this.matricule4 = matricule4;
			this.matricule5 = matricule5;
			this.nomEquipe = nomEquipe;
            this.nomTest = nomTest;
        }

		public string Matricule1
		{
			get { return matricule1; }
		}

		public string Matricule2
		{
			get { return matricule2; }
		}

		public string Matricule3
		{
			get { return matricule3; }
		}

		public string Matricule4
		{
			get { return matricule4; }
		}

		public string Matricule5
		{
			get { return matricule5; }
		}

		public string NomEquipe
        {
            get { return nomEquipe; }
        }

        public string NomTest
        {
            get { return nomTest; }
        }
    }
}
