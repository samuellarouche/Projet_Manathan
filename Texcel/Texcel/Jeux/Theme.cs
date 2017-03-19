using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Theme
    {
        string nom, description;
        int codeTheme;

        public Theme(int codeTheme, string nom, string description)
        {
            this.nom = nom;
            this.description = description;
            this.codeTheme = codeTheme;
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Description
        {
            get { return description; }
        }

        public int CodeTheme
        {
            get { return codeTheme; }
        }

        public override string ToString()
        {
            return nom;
        }
    }
}
