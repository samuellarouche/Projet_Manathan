using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
	class TestController : Controller
	{
		List<Test> lstTest = new List<Test>();

		public TestController()
		{
			Select("");
		}

		public override void Insert(object champs)
		{
			throw new NotImplementedException();
		}

        //Sélectionne tous les tests de la BD et les insère dans une liste.
		public override void Select(string where)
		{
			lstTest.Clear();
			foreach (object[] testSelectionne in Provider.CommandeLecture("SELECT * FROM vueTest " + where))
			{
				Test test;
				test = new Test(testSelectionne[0].ToString(), testSelectionne[1].ToString(), Convert.ToInt32(testSelectionne[2]));

				lstTest.Add(test);
			}

		}

		public override void Delete(string primaryKey)
		{
			throw new NotImplementedException();
		}

		public List<Test> ListTest
		{
			get { return lstTest; }
		}
	}
}
   