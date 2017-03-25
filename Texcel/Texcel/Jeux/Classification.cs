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

        public Classification(string nom, string description)
        {
            this.nom = nom;
            this.description = description;
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Description
        {
            get { return description; }
        }

        public override string ToString()
        {
            return nom;
        }
    }
}
