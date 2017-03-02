using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class PlateformeController
    {
        List<Plateforme> listPlateforme = new List<Plateforme>();
        Plateforme plateforme;

        public PlateformeController()
        {

        }

        //Permet de créer une plateforme dans la BD.
        public void CreerPlateforme(string nom, string configuration, string type, OS os)
        {
            plateforme = new Plateforme(nom, configuration, type, os);
            listPlateforme.Add(plateforme);
        }

        public List<Plateforme> ListPlateforme
        {
            get { return listPlateforme; }
        }
    }
}
