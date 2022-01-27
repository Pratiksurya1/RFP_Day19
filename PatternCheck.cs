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
      //  public string Regex_Pattern = "^[A-Za-z]{3,}$";

        public bool FirstName(string FirstName)
        {
             string Regex_Pattern = "^[A-Z]{1}[a-z]{3,}$";

            return Regex.IsMatch(FirstName, Regex_Pattern);
        }
    }
}
