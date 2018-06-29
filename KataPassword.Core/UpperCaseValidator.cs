using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KataPassword.Core
{
    class UpperCaseValidator : Validator
    {
        public override int HandleRequest(Request request)
        {
            Regex regex = new Regex(@"(?=.*[A-Z])");
            Match match = regex.Match(request.Password);
            if (match.Success) request.Strength++;
            if (request.Strength > 2 || successor == null) return request.Strength;
            return successor.HandleRequest(request);
        }
    }
}
