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
