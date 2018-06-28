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
            var pwdstrength = 0;
            
            if (string.IsNullOrWhiteSpace(pwd)) return false;

            if (pwd.Length < 8) return false;
            pwdstrength++;

            Regex regex = new Regex(@"(?=.*[a-z])");
            Match match = regex.Match(pwd);
            if (match.Success) pwdstrength++;

             regex = new Regex(@"(?=.*[A-Z])");
             match = regex.Match(pwd);
            if (match.Success) pwdstrength++;

            regex = new Regex(@"(?=.*\d)");
            match = regex.Match(pwd);
            if (match.Success) pwdstrength++;

            regex = new Regex(@"(?=.*[!@#$%^&*()_+=])");
            match = regex.Match(pwd);
            if (match.Success) pwdstrength++;


            return pwdstrength > 2;
        }
    }

}
