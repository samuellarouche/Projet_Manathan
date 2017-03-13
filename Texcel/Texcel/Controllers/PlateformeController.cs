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
            Select();
        }

        //Permet de créer une plateforme dans la BD.
        public override void Insert(params string[] champs)
        {
            Provider.ExecuterCommande("INSERT INTO tblPlateforme VALUES (@0, @1, @2);", champs[0], champs[1], champs[2]);//Manque OS pas encore dans la BD
        }

        //Permet de récupérer toutes les plateformes de la BD.
        public override void Select()
        {
            Plateforme plateforme;

            foreach(object[] selection in Provider.CommandeLecture("SELECT * FROM tblPlateforme"))
            {
                plateforme = new Plateforme(selection[0].ToString(), selection[1].ToString(), selection[2].ToString(), null);
                listPlateforme.Add(plateforme);
            }
        }

        public List<Plateforme> ListPlateforme
        {
            get { return listPlateforme; }
        }
    }
}
