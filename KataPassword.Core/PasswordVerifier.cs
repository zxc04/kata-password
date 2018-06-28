using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPassword.Core
{
    public  class PasswordVerifier
    {
        public static bool IsPwdValid(string pwd)
        { 
            if(string.IsNullOrWhiteSpace(pwd)) return false;
            return true;
        }
    }
 
}
