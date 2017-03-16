using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Jeu
    {
        string nom, developpeur, description, configMin, codePlateforme, codeClassification, codeTheme, codeGenre;

        public Jeu(string nom, string developpeur, string description, string configMin, string codePlateforme, string codeClassification, string codeGenre, string codeTheme)
        {
            this.nom = nom;
            this.developpeur = developpeur;
            this.description = description;
            this.configMin = configMin;
            this.codePlateforme = codePlateforme;
            this.codeClassification = codeClassification;
            this.codeTheme = codeTheme;
            this.codeGenre = codeGenre;
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
    }
}
