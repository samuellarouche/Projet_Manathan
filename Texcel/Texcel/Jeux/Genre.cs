using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Genre
    {
        string nom, description;
        int codeGenre;

        public Genre(int codeGenre, string nom, string description)
        {
            this.nom = nom;
            this.description = description;
            this.codeGenre = codeGenre;
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Description
        {
            get { return description; }
        }

        public int CodeGenre
        {
            get { return codeGenre; }
        }

        public override string ToString()
        {
            return nom;
        }
    }
}
