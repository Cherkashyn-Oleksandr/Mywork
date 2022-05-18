using System;

namespace LoginPageAndSmartID
{
    public class SmartIdTroubleException : Exception
    {
        public Trouble Trouble { get; }

        public SmartIdTroubleException(Trouble trouble) : base(trouble.ToString())
        {
            Trouble = trouble;
        }
    }
}