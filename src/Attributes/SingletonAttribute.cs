using System;

namespace DependencyInjection.Registration.Collectio.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class SingletonAttribute : AbstractRegistrationAttribute
    {
        public SingletonAttribute(Type registrationTarget) : base(registrationTarget)
        {
        }
    }
}
