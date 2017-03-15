using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class PlateformeController : Controller
    {
        List<Plateforme> listPlateforme = new List<Plateforme>();

        public PlateformeController() : base()
        {
            Select("");
        }

        //Permet de créer une plateforme dans la BD.
        public override void Insert(params object[] champs)
        {
            OS os = (OS)champs[3];
            Provider.ExecuterCommande("INSERT INTO tblPlateforme VALUES (@0, @1, @2, @3);", champs[0], champs[1], champs[2], os.Code);//Manque la primary key
            //Ajouter la plateforme dans la liste de plateforme.
        }

        //Permet de récupérer toutes les plateformes de la BD.
        public override void Select(string where)
        {
            Plateforme plateforme;

            foreach(object[] selection in Provider.CommandeLecture("SELECT * FROM tblPlateforme" + where))
            {
                plateforme = new Plateforme(selection[1].ToString(), selection[2].ToString(), selection[3].ToString(), null);//Faire une requete pour trouver le OS selon le code.
                listPlateforme.Add(plateforme);
            }
        }

        public List<Plateforme> ListPlateforme
        {
            get { return listPlateforme; }
        }
    }
}
