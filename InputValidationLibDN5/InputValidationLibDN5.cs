using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace InputValidationLibDN5
{
    public class IVL5
    {
        /// <summary>
        /// Validates if an inputed string is alphabetic
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="restrictions"></param>
        /// <returns>bool of true = contains only alphabetic, false = contains non-alphabetic</returns>
        public static bool stringisAlpha(string inputString)
        {

            Regex alphanum = new Regex("^[A-Za-z]*$");

            bool isAlpha = alphanum.IsMatch(inputString);
            return isAlpha;
        }

        /// <summary>
        /// Validates if an inputed string is alphanumeric
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>bool of true = contains only alphanumeric, false = contains non-alphanumeric</returns>
        public static bool stringisAlphaNum(string inputString)
        {
            Regex regexAlphaNum = new Regex("^[A-Za-z0-9]*$");
            bool isAlpha = regexAlphaNum.IsMatch(inputString);
            return isAlpha;
        }

        /// <summary>
        /// Validates if an inputed string is a digit
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>bool of true = contains only digits, false = contains non-digits</returns>
        public static bool stringisDigit(string inputString)
        {
            Regex regexDigits = new Regex("^[0-9]*$");
            bool isDigit = regexDigits.IsMatch(inputString);
            return isDigit;
        }

        /// <summary>
        /// Validates if an inputed string is a decimal (digit + .)
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>bool of true = contains only digits and '.', false = contains non-decimal</returns>
        public static bool stringisDecimal(string inputString)
        {
            Regex regexDecimals = new Regex("^[+-]?([0-9]+.?[0-9]*|.[0-9]+)$");
            bool isDecimal = regexDecimals.IsMatch(inputString);
            return isDecimal;
        }

        /// <summary>
        /// Validates if an inputed string is a 'y' or 'n' for conformation inputs
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>bool of true = contains only 'y','Y','n',and 'N', false = contains anything else</returns>
        public static bool stringisYN(string inputString)
        {
            bool isYN;
            if ((new[] { "y", "Y", "n", "N" }).Contains(inputString))
            {
                isYN = true;
            }
            else
            {
                isYN = false;
            }
            return isYN;
        }

        /// <summary>
        /// Validates if an inputed string is a 't' or 'f' for conformation inputs
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>bool of true = contains only 't','T','f',and 'F', false = contains anything else</returns>
        public static bool stringisTF(string inputString)
        {
            bool isTF;
            if ((new[] { "t", "T", "f", "F" }).Contains(inputString))
            {
                isTF = true;
            }
            else
            {
                isTF = false;
            }
            return isTF;
        }
    }
}
