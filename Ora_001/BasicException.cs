namespace Ora_001
{
    internal class BasicException : Exception
    {
        public BasicException() : base()
        {
             
        }

        public BasicException(string error) : base()
        {
            this.Error = error;
        }
        public string? Error { get; private set; }
    }
}
