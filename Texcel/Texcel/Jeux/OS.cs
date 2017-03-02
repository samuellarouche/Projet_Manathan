using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class OS
    {
        string nom, version, code, edition;

        public OS(string nom, string version, string code, string edition)
        {
            this.nom = nom;
            this.version = version;
            this.code = code;
            this.edition = edition;
        }

        public override string ToString()
        {
            return nom;
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Version
        {
            get { return version; }
        }

        public string Code
        {
            get { return code; }
        }

        public string Edition
        {
            get { return edition; }
        }
    }
}
