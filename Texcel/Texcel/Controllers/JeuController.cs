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

        public JeuController() : base()
        {

        }

        //Permet de créer un jeu dans la BD.
        public override void Insert(params object[] champs)
        {
            Provider.ExecuterCommande("INSERT INTO tblJeux VALUES (@0, @1, @2, @3, @4, @5, @6)", champs[0], champs[1], champs[2], champs[3], champs[4], champs[5], champs[6]);//Pas encore de plateforme dans la bd
        }

        //Permet de récupérer tous les jeux de la BD.
        public override void Select(string where)
        {
            Jeu jeu;

            listJeu.Clear();
            foreach(object[] jeuSelectionne in Provider.CommandeLecture("SELECT * FROM tblJeux" + where))
            {
                jeu = new Jeu(jeuSelectionne[0].ToString(), jeuSelectionne[1].ToString(), jeuSelectionne[2].ToString(), jeuSelectionne[3].ToString(), jeuSelectionne[4].ToString(), jeuSelectionne[5].ToString(), jeuSelectionne[6].ToString(), jeuSelectionne[7].ToString());
                listJeu.Add(jeu);
            }
        }

        public List<Jeu> ListJeu
        {
            get { return listJeu; }
        }
    }
}
