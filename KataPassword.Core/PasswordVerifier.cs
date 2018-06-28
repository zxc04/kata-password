using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return pwdstrength > 2;
        }
    }

}
