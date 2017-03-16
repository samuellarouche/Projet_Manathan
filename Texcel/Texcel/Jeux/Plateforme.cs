using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Plateforme
    {
        string nom, configuration, typeConfig, codeOS;

        public Plateforme(string nom, string configuration, string typeConfig, string codeOS)
        {
            this.nom = nom;
            this.configuration = configuration;
            this.typeConfig = typeConfig;
            this.codeOS = codeOS;
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
            get { return typeConfig; }
        }

        public string CodeOS
        {
            get { return codeOS; }
        }
    }
}
