using System.Text.RegularExpressions;

namespace KataPassword.Core
{
    public class LowerCaseValidator : Validator
    {
        public override int HandleRequest(Request request)
        {
            Regex regex = new Regex(@"(?=.*[a-z])");
            Match match = regex.Match(request.Password);
            if (match.Success) request.Strength++;
            if (request.Strength > 2 || successor == null) return request.Strength;
            return successor.HandleRequest(request);

        }
    }
}
