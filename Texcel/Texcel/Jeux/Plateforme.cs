using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Plateforme
    {
        OS os;
        string nom, configuration, type;

        public Plateforme(string nom, string configuration, string type, OS os)
        {
            this.nom = nom;
            this.configuration = configuration;
            this.type = type;
            this.os = os;
        }

        public override string ToString()
        {
            return nom;
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Configuration
        {
            get { return configuration; }
        }

        public string Type
        {
            get { return type; }
        }

        public OS OS
        {
            get { return os; }
        }
    }
}
