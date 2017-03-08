using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Texcel
{
    class dbProvider
    {
        public dbProvider()
        {

        }

        public string ExecuterCommande(string commande, params object[] valeurs)
        {           
            string asd = "";


            using(SqlConnection connexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=NORTHWND;Trusted_Connection=True;"))
            {
                connexion.Open();

                SqlCommand command = new SqlCommand(commande, connexion);

                for(int i = 0; i < valeurs.Length; i++)
                {
                    command.Parameters.Add(new SqlParameter(i.ToString(), valeurs[i]));
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        asd += " " + reader[0] + " " + reader[1] + " " + reader[2];
                    }
                }
            }

            return asd;
        }
    }
}
