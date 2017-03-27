using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class Test
    {
		string nom, descriptionTest;
		int codeType;

        public Test(string nom, string descriptionTest, int codeType)
        {
			this.nom = nom;
			this.descriptionTest = descriptionTest;
			this.codeType = codeType;
        }

		public string Nom
		{
			get { return nom; }
		}

		public string DescriptionTest
		{
			get {return descriptionTest; }
		}

		public int CodeType
		{
			get {return codeType; }
		}

        public override string ToString()
        {
            return nom;
        }
    }
}
