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
            Provider.ExecuterCommande("INSERT INTO vuePlateforme (nom, configuration, typeConfiguration, codeOS) VALUES (@0, @1, @2, @3);", champs[0], champs[1], champs[2], os.Code);

            listPlateforme.Add(new Plateforme(champs[0].ToString(), champs[1].ToString(), champs[2].ToString(), os.Code));
        }

        //Permet de récupérer toutes les plateformes de la BD.
        public override void Select(string where)
        {
            Plateforme plateforme;

            listPlateforme.Clear();
            foreach (object[] plateformeSelectionnee in Provider.CommandeLecture("SELECT * FROM vuePlateforme " + where))
            {
                plateforme = new Plateforme(plateformeSelectionnee[0].ToString(), plateformeSelectionnee[1].ToString(), plateformeSelectionnee[2].ToString(), plateformeSelectionnee[4].ToString());
                listPlateforme.Add(plateforme);
            }
        }

        public override void Delete(string primaryKey)
        {
            Provider.ExecuterCommande("DELETE FROM vuePlateforme WHERE nom = '" + primaryKey + "'");
        }

        public List<Plateforme> ListPlateforme
        {
            get { return listPlateforme; }
        }
    }
}
