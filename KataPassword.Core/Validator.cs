using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPassword.Core
{
    public abstract class Validator
    {

        protected Validator successor;
        public void SetSuccessor(Validator successor)
        {
            this.successor = successor;
        }

        public abstract int HandleRequest(Request request);

    }
}
