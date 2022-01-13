using System;

namespace DependencyInjection.Registration.Collectio.Exceptions
{
    internal class IllegalRegistrationTargetException : Exception
    {
        public IllegalRegistrationTargetException(string message) : base(message)
        {
        }
    }
}
