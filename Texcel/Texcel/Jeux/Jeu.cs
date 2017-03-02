using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Jeu
    {
        string nom, developpeur, description, configMin;
        Plateforme plateforme;

        public Jeu(string nom, string developpeur, string description, string configMin, Plateforme plateforme)
        {
            this.nom = nom;
            this.developpeur = developpeur;
            this.description = description;
            this.configMin = configMin;
            this.plateforme = plateforme;
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

        public Plateforme Plateforme
        {
            get { return plateforme; }
        }
    }
}
