using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Jeu
    {
        string nom, developpeur, description, configMin, nomPlateforme, codeClassification, codeTheme, codeGenre, nomJeuAssocie;//Changer code pour nom

        public Jeu(string nom, string developpeur, string description, string configMin, string nomPlateforme, string codeClassification, string codeGenre, string codeTheme, string jeuAssocie)
        {
            this.nom = nom;
            this.developpeur = developpeur;
            this.description = description;
            this.configMin = configMin;
            this.nomPlateforme = nomPlateforme;
            this.codeClassification = codeClassification;
            this.codeTheme = codeTheme;
            this.codeGenre = codeGenre;
            this.nomJeuAssocie = jeuAssocie;
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

        public string NomPlateforme
        {
            get { return nomPlateforme; }
        }

        public string CodeClassification
        {
            get { return codeClassification; }
        }

        public string CodeGenre
        {
            get { return codeGenre; }
        }

        public string CodeTheme
        {
            get { return codeTheme; }
        }

        public string NomJeuAssocie
        {
            get { return nomJeuAssocie; }
            set { nomJeuAssocie = value; }
        }

        public override string ToString()
        {
            return nom;
        }
    }
}
