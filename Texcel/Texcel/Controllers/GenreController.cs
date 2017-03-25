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
        Genre genre;

        public GenreController()
        {
            Select("");
        }

        //Permet de créer un genre dans la BD.
        public override void Insert(object item)
        {
            genre = (Genre)item;

            Provider.ExecuterCommande("INSERT INTO vueGenre (nomGenre, descriptionGenre) VALUES(@0, @1)", genre.Nom, genre.Description);
            Select("");//Sert à insérer les genres dans la liste lors de l'insertion.
        }

        //Permet de récupérer tous les genres de la BD.
        public override void Select(string where)
        {           
            listGenre.Clear();
            foreach (object[] genreSelectionne in Provider.CommandeLecture("SELECT * FROM vueGenre " + where))
            {
                genre = new Genre(genreSelectionne[1].ToString(), genreSelectionne[2].ToString());
                listGenre.Add(genre);
            }
        }

        public override void Delete(string where)
        {
            throw new NotImplementedException();
        }

        public List<Genre> ListGenre
        {
            get { return listGenre; }
        }
    }
}
