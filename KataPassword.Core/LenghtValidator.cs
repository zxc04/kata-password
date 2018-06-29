namespace KataPassword.Core
{
    public class LenghtValidator : Validator
    {
        public override int HandleRequest(Request request)
        {
            if (string.IsNullOrWhiteSpace(request.Password) || request.Password.Length < 8) return 0;
            request.Strength++;
            if (request.Strength > 2 || successor == null) return request.Strength;
            return successor.HandleRequest(request);
        }
    }
}
