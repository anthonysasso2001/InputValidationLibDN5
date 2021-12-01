using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace InputValidationLibDN5
{
    public class InputValidation
    {
        /// <summary>
        /// Validates if the inputed string qualifies as alphabetic
        /// </summary>
        /// <param name="inputString">inputString is the inputed string to be tested</param>
        /// <returns>bool of true or false of if the string is alphabetic</returns>
        public static bool stringisAlpha(string inputString)
        {

            Regex regexAlpha = new Regex("^[A-Za-z]*$");

            bool isAlpha = regexAlpha.IsMatch(inputString);
            return isAlpha;
        }

        /// <summary>
        /// Validates if the inputed string qualifies as alphanumeric
        /// </summary>
        /// <param name="inputString">inputString is the inputed string to be tested</param>
        /// <returns>bool of true or false if the string is alphanumeric</returns>
        public static bool stringisAlphaNum(string inputString)
        {
            Regex regexAlphaNum = new Regex("^[A-Za-z0-9]*$");
            bool isAlpha = regexAlphaNum.IsMatch(inputString);
            return isAlpha;
        }

        /// <summary>
        /// Validates if the inputed string qualifies as a number
        /// </summary>
        /// <param name="inputString">inputString is the inputed string to be tested</param>
        /// <returns>bool of true or false if the string is a number</returns>
        public static bool stringisDigit(string inputString)
        {
            Regex regexDigits = new Regex("^[0-9]*$");
            bool isDigit = regexDigits.IsMatch(inputString);
            return isDigit;
        }

        /// <summary>
        /// Validates if the inputed string qualifies as a decimal
        /// </summary>
        /// <param name="inputString">the inputed string to be tested</param>
        /// <returns>bool of true or false if the string is a decimal</returns>
        public static bool stringisDecimal(string inputString)
        {
            Regex regexDecimals = new Regex("^[+-]?([0-9]+.?[0-9]*|.[0-9]+)$");
            bool isDecimal = regexDecimals.IsMatch(inputString);
            return isDecimal;
        }

        /// <summary>
        /// Validates if the inputed string is y or n or invalid to confirm inputs
        /// </summary>
        /// <remarks>
        /// Allowed y inputs are:
        ///     y, Y, yes, Yes, YES,
        ///     which resolve to 1
        /// 
        /// Allowed n inputs are:
        ///     n, N, no, No, NO,
        ///     which resolve to 0
        /// 
        /// Invalid inputs resolve to -1
        /// </remarks>
        /// <param name="inputString">the inputed string to be tested</param>
        /// <returns>int of 1 for true, 0 for false, -1 for invalid</returns>
        public static int stringisYN(string inputString)
        {
            Regex regexYes = new Regex("^([y]|[Y]|(yes)|(Yes)|(YES))$");
            Regex regexNo = new Regex("^([n]|[N]|(no)|(No)|(NO))$");

            int isYN;
            if (regexYes.IsMatch(inputString))
            {
                isYN = 1;
            }
            else if (regexNo.IsMatch(inputString))
            {
                isYN = 0;
            }
            else
            {
                isYN = -1;
            }

            return isYN;
        }

        /// <summary>
        /// Validates if the inputed string is t or f or invalid to confirm inputs
        /// </summary>
        /// <remarks>
        /// Allowed t inputs are:
        ///     t, T, true, True, TRUE,
        ///     which resolve to 1
        /// 
        /// Allowed n inputs are:
        ///     f, F, false, False, FALSE,
        ///     which resolve to 0
        /// 
        /// Invalid inputs resolve to -1
        /// </remarks>
        /// <param name="inputString">the inputed string to be tested</param>
        /// <returns>int of 1 for true, 0 for false, -1 for invalid</returns>
        public static int stringisTF(string inputString)
        {
            Regex regexTrue = new Regex("^([t]|[T]|(true)|(True)|(TRUE))$");
            Regex regexFalse = new Regex("^([f]|[F]|(false)|(False)|(FALSE))$");

            int isTF;
            if (regexTrue.IsMatch(inputString))
            {
                isTF = 1;
            }
            else if (regexFalse.IsMatch(inputString))
            {
                isTF = 0;
            }
            else
            {
                isTF = -1;
            }

            return isTF;
        }
    }
}
