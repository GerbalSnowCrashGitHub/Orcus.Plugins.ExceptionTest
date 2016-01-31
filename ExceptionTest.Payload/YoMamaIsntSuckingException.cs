using System;

namespace ExceptionTest.Payload
{
    public class YoMamaIsntSuckingException : Exception
    {
        public YoMamaIsntSuckingException(string message) : base(message)
        {
        }
    }
}