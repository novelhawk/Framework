using System;

namespace Hawk.Framework.Exceptions
{
    public class GLException : Exception
    {
        public GLException(string message, string longMessage = null) : base(message)
        {
            LongMessage = longMessage;
        }

        public string LongMessage { get; }      
    }
}