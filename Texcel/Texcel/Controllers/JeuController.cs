using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class JeuController : Controller
    {
        List<Jeu> listJeu = new List<Jeu>();
        Jeu jeu;

        public JeuController() : base()
        {
            Select("");
        }

        //Permet de créer un jeu dans la BD.
        public override void Insert(object item)
        {
            jeu = (Jeu)item;

            Provider.ExecuterCommande("INSERT INTO vueJeu (nom, developpeur, descriptionJeu, configMin, nomPlateforme, nomGenre, nomClassification, nomTheme, nomJeuAssocie) VALUES (@0, @1, @2, @3, @4, @5, @6, @7, @8)", 
                jeu.Nom, jeu.Developpeur, jeu.Description, jeu.ConfigMin, jeu.NomPlateforme, jeu.CodeGenre, jeu.CodeClassification, jeu.CodeTheme, jeu.NomJeuAssocie);

            listJeu.Add(jeu);
        }

        //Permet de récupérer tous les jeux de la BD.
        public override void Select(string where)
        {
            listJeu.Clear();
            foreach(object[] jeuSelectionne in Provider.CommandeLecture("SELECT * FROM vueJeu " + where))
            {
                jeu = new Jeu(jeuSelectionne[1].ToString(), jeuSelectionne[2].ToString(), jeuSelectionne[3].ToString(), jeuSelectionne[4].ToString(),
                    jeuSelectionne[5].ToString(), jeuSelectionne[6].ToString(), jeuSelectionne[7].ToString(), jeuSelectionne[8].ToString(), jeuSelectionne[9].ToString());

                listJeu.Add(jeu);
            }
        }

        //Supprime un jeu de la BD et de la liste.
        public override void Delete(string primaryKey)
        {
            Provider.ExecuterCommande("DELETE FROM vueJeu WHERE nom = '" + primaryKey + "'");

            Select("");
        }

        public List<Jeu> ListJeu
        {
            get { return listJeu; }
        }
    }
}
