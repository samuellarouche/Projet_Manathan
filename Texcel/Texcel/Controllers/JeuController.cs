using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class JeuController
    {
        List<Jeu> listJeu = new List<Jeu>();
        Jeu jeu;

        public JeuController()
        {

        }

        //Permet de créer un jeu dans la BD.
        public void CreerJeu(string nom, string developpeur, string description, string configMin, Plateforme plateforme)
        {
            jeu = new Jeu(nom, developpeur, description, configMin, plateforme);
            listJeu.Add(jeu);
        }

        public List<Jeu> ListJeu
        {
            get { return listJeu; }
        }
    }
}
