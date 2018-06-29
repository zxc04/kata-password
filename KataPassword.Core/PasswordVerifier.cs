using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KataPassword.Core
{
    public class PasswordVerifier
    {
        public static bool IsPwdValid(string pwd)
        {
           
            var request = new Request { Password = pwd, Strength = 0 };

            //Setup responsables
            var lenghtValidator = new LenghtValidator();
            var lowerCaseValidator = new LowerCaseValidator();
            var upperCaseValidator = new UpperCaseValidator();
            var digitValidator = new DigitValidator();
            var symbolValidator = new SymbolValidator();

            //// Setup Chain of Responsibility
            lenghtValidator.SetSuccessor(lowerCaseValidator);
            lowerCaseValidator.SetSuccessor(upperCaseValidator);
            upperCaseValidator.SetSuccessor(digitValidator);
            digitValidator.SetSuccessor(symbolValidator);

            return lenghtValidator.HandleRequest(request) > 2;
        }
    }

}
