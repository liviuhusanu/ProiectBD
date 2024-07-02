using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarieModele
{
    public struct LengthConstraints
    {
        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        public LengthConstraints(int minLength, int maxLength)
        {
            MinLength = minLength;
            MaxLength = maxLength;
        }
    }
    public class ValidareDate
    {
        public static string ValidateTextBoxWithRegex(TextBox textBox, string pattern, string errorMessage)
        {
            if (!Regex.IsMatch(textBox.Text, pattern))
            {
                return errorMessage;
            }

            return string.Empty;
        }

        public static string CombineErrorMessages(string errorMessage1, string errorMessage2)
        {
            if (string.IsNullOrEmpty(errorMessage1))
            {
                return errorMessage2;
            }
            if (string.IsNullOrEmpty(errorMessage2))
            {
                return errorMessage1;
            }

            return $"{errorMessage1} {errorMessage2}";
        }
        
    }
}
