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

        public ThemeController()
        {
            Select("");
        }

        //Permet de créer un thème dans la BD.
        public override void Insert(params object[] champs)
        {
            Provider.ExecuterCommande("INSERT INTO vueTheme (nomTheme, descriptionTheme) VALUES(@0, @1)", champs[0], champs[1]);
        }

        //Permet de récupérer tous les thèmes de la BD.
        public override void Select(string where)
        {
            Theme theme;

            listTheme.Clear();
            foreach (object[] themeSelectionne in Provider.CommandeLecture("SELECT * FROM vueTheme " + where))
            {
                theme = new Theme(Convert.ToInt32(themeSelectionne[0]), themeSelectionne[1].ToString(), themeSelectionne[2].ToString());
                listTheme.Add(theme);
            }
        }

        public List<Theme> ListTheme
        {
            get { return listTheme; }
        }
    }
}
