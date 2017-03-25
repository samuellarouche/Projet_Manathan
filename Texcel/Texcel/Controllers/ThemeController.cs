using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class ThemeController : Controller
    {
        List<Theme> listTheme = new List<Theme>();
        Theme theme;

        public ThemeController()
        {
            Select("");
        }

        //Permet de créer un thème dans la BD.
        public override void Insert(object item)
        {
            theme = (Theme)item;

            Provider.ExecuterCommande("INSERT INTO vueTheme (nomTheme, descriptionTheme) VALUES(@0, @1)", theme.Nom, theme.Description);
            Select("");//Sert à insérer les thèmes dans la liste lors de l'insertion.
        }

        //Permet de récupérer tous les thèmes de la BD.
        public override void Select(string where)
        {          
            listTheme.Clear();
            foreach (object[] themeSelectionne in Provider.CommandeLecture("SELECT * FROM vueTheme " + where))
            {
                theme = new Theme(themeSelectionne[1].ToString(), themeSelectionne[2].ToString());
                listTheme.Add(theme);
            }
        }

        public override void Delete(string where)
        {
            throw new NotImplementedException();
        }

        public List<Theme> ListTheme
        {
            get { return listTheme; }
        }
    }
}
