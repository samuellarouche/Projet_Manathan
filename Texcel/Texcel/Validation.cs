using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Texcel
{
    class Validation
    {
        Regex rgx;

        public Validation()
        {

        }

        //Vérifie les champs de façons général.
        public bool VerifierChampsCommun(string champ)
        {
            if ((champ.Length > 0) && (champ.Length <= 50))
                return true;
            else
                return false;
        }

        //Vérifie le mot de passe.
        public bool VerifierMotPasse(string champ)
        {
            rgx = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,18}$");

            if (rgx.IsMatch(champ))
                return true;
            else
                return false;
        }

        //Vérifie si le mot de passe a bien été saisie dans la confirmation.
        public bool ConfirmationMotPasse(string motPasse, string confirmation)
        {
            if (motPasse == confirmation)
                return true;
            else
                return false;
        }

        //Vérifie le numéro de téléphone.
        public bool VerifierNoTel(string champ)
        {
            rgx = new Regex("\\(?\\d{3}\\)?-? *\\d{3}-? *-?\\d{4}");

            if (rgx.IsMatch(champ))
                return true;
            else
                return false;
        }

        //Vérifie le poste téléphonique.
        public bool VerifierPosteTel(string champ)
        {
            if ((champ.Length > 0) && (champ.Length < 6))
                return true;
            else
                return false;
        }
    }
}
