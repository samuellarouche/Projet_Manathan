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
        public override void Insert(params string[] champs)
        {
            Provider.ExecuterCommande("INSERT INTO tblJeux VALUES (@0, @1, @2, @3)", champs[0], champs[1], champs[2], champs[3]);//Pas encore de plateforme dans la bd
        }

        //Permet de récupérer tous les jeux de la BD.
        public override void Select()
        {
            Jeu jeu;

            foreach(object[] selection in Provider.CommandeLecture("SELECT * FROM tblJeux"))
            {
                jeu = new Jeu(selection[0].ToString(), selection[1].ToString(), selection[2].ToString(), selection[3].ToString(), null);
                listJeu.Add(jeu);
            }
        }

        public List<Jeu> ListJeu
        {
            get { return listJeu; }
        }
    }
}
