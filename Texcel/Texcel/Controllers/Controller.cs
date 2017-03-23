using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    abstract class Controller
    {
        dbProvider provider = new dbProvider();

        public Controller()
        {

        }

        protected dbProvider Provider
        {
            get { return provider; }
        }

        public abstract void Insert(params object[] champs);

        public abstract void Select(string where);

        public abstract void Delete(string primaryKey);
    }
}
