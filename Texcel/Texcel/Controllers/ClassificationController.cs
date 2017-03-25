using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel
{
    class ClassificationController : Controller
    {
        List<Classification> listClassification = new List<Classification>();
        Classification classification;

        public ClassificationController()
        {
            Select("");
        }

        //Permet de créer une classification dans la BD.
        public override void Insert(object item)
        {
            classification = (Classification)item;

            Provider.ExecuterCommande("INSERT INTO tblClassification (nomClassification, descriptionClassification) VALUES(@0, @1)", classification.Nom, classification.Description);
            Select("");//Sert à insérer les classifications dans la liste lors de l'insertion.
        }

        //Permet de récupérer toutes les classifications de la BD.
        public override void Select(string where)
        {
            listClassification.Clear();
            foreach(object[] classificationSelectionnee in Provider.CommandeLecture("SELECT * FROM tblClassification " + where))
            {
                classification = new Classification(classificationSelectionnee[1].ToString(), classificationSelectionnee[2].ToString());
                listClassification.Add(classification);
            }
        }

        public override void Delete(string primaryKey)
        {
            throw new NotImplementedException();
        }

        public List<Classification> ListClassification
        {
            get { return listClassification; }
        }
    }
}
