using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class GenreController : Controller
    {
        List<Genre> listGenre = new List<Genre>();

        public GenreController()
        {
            Select("");
        }

        public override void Insert(params object[] champs)
        {
            Provider.ExecuterCommande("INSERT INTO vueGenre (nomGenre, descriptionGenre) VALUES(@0, @1)", champs[0], champs[1]);
            //Trouver un moyen pour ajouter les genres dans la liste lors de l'insertion.
            //Trouver un moyen pour afficher les noms au lieu des codes dans la listView.
        }

        public override void Select(string where)
        {
            Genre genre;

            listGenre.Clear();
            foreach (object[] genreSelectionne in Provider.CommandeLecture("SELECT * FROM vueGenre " + where))
            {
                genre = new Genre(Convert.ToInt32(genreSelectionne[0]), genreSelectionne[1].ToString(), genreSelectionne[2].ToString());
                listGenre.Add(genre);
            }
        }

        public List<Genre> ListGenre
        {
            get { return listGenre; }
        }
    }
}
