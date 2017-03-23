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

        public ClassificationController()
        {
            Select("");
        }

        //Permet de créer une classification dans la BD.
        public override void Insert(params object[] champs)
        {
            Provider.ExecuterCommande("INSERT INTO tblClassification (nomClassification, descriptionClassification) VALUES(@0, @1)", champs[0], champs[1]);
            Select("");//Sert à insérer les classifications dans la liste lors de l'insertion.
        }

        //Permet de récupérer toutes les classifications de la BD.
        public override void Select(string where)
        {
            Classification classification;

            listClassification.Clear();
            foreach(object[] classificationSelectionnee in Provider.CommandeLecture("SELECT * FROM tblClassification " + where))
            {
                classification = new Classification(Convert.ToInt32(classificationSelectionnee[0]), classificationSelectionnee[1].ToString(), classificationSelectionnee[2].ToString());
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
