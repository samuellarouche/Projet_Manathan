using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Threading;
using System.Data.SqlClient;

namespace Texcel
{
    class dbProvider
    {
        public dbProvider()
        {

        }

        //Éxecute une commande SQL avec paramètres.
        public void ExecuterCommande(string script, params object[] valeurs)
        {           
            using(SqlConnection connexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=BD_Texcel;Trusted_Connection=True;"))
            {
                connexion.Open();

                SqlCommand commande = new SqlCommand(script, connexion);

                for(int i = 0; i < valeurs.Length; i++)
                {
                    commande.Parameters.Add(new SqlParameter(i.ToString(), valeurs[i]));
                }

                commande.ExecuteNonQuery();
            }
        }

        //Éxecute une commande SQL et retourne la liste de toutes les valeurs de chaque ligne.
        public List<object[]> CommandeLecture(string script)
        {
            List<object[]> donnees = new List<object[]>();           

            using (SqlConnection connexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=NORTHWND;Trusted_Connection=True;"))
            {
                connexion.Open();

                SqlCommand commande = new SqlCommand(script, connexion);

                using (SqlDataReader reader = commande.ExecuteReader())
                {
                    object[] ligne = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(ligne);
                        donnees.Add(ligne);
                        ligne = new object[reader.FieldCount];
                    }
                }
            }

            return donnees;
        }
    }
}
