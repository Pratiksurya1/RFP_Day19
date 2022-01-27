using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Demo
{

    internal class PatternCheck
    {
        public bool FirstName(string FirstName)
        {
            string Regex_Pattern = "^[A-Z]{1}[a-z]{3,}$";

            return Regex.IsMatch(FirstName, Regex_Pattern);
        }

        public bool LastName(string LastName)
        {
            string Regex_Pattern = "^[A-Z][a-zA-z]{3,}$";

            return Regex.IsMatch(LastName, Regex_Pattern);
        }

        public bool EMail(String mailID)
        {
            string Regex_Pattern = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            return Regex.IsMatch(mailID, Regex_Pattern);
        }

        public bool MNumber(String Mnum)
        {
            String Regex_Pattern = "^[9][1][7-9]{1}[0-9]{9}$";
            return Regex.IsMatch(Mnum, Regex_Pattern);
        }

        public bool Password(String Pass)
        {
            String Regex_Pattern = "^[A-Za-z]{8,}$";
            return Regex.IsMatch(Pass, Regex_Pattern);
        }

        public bool PasswordCase2(String pass)
        {
            String Regax_Pattern = "^[A-Za-z]{8,}$";
            return Regex.IsMatch(pass, Regax_Pattern);
        }

        public bool PasswordCase3(String pass)
        {
            String Regax_Pattern = "^[A-Za-z]{8,}$";
            return Regex.IsMatch(pass, Regax_Pattern);
        }

        public bool PasswordCase4(String pass)
        {
            String Regax_Pattern = "^[A-Za-z]{8,}$";
            return Regex.IsMatch(pass, Regax_Pattern);
        }
    }
}
