using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Jeu
    {
        string nom, developpeur, description, configMin, codePlateforme;

        public Jeu(string nom, string developpeur, string description, string configMin, string codePlateforme)
        {
            this.nom = nom;
            this.developpeur = developpeur;
            this.description = description;
            this.configMin = configMin;
            this.codePlateforme = codePlateforme;
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Developpeur
        {
            get { return developpeur; }
        }

        public string Description
        {
            get { return description; }
        }

        public string ConfigMin
        {
            get { return configMin; }
        }

        public string CodePlateforme
        {
            get { return codePlateforme; }
        }
    }
}
