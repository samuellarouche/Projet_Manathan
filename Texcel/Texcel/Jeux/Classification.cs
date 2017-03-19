using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Classification
    {
        string nom, description;
        int codeClassification;

        public Classification(int codeClassification, string nom, string description)
        {
            this.nom = nom;
            this.description = description;
            this.codeClassification = codeClassification;
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Description
        {
            get { return description; }
        }

        public int CodeClassification
        {
            get { return codeClassification; }
        }

        public override string ToString()
        {
            return nom;
        }
    }
}
