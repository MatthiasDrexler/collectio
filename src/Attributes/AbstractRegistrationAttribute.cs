using System;
using DependencyInjection.Registration.Collectio.Exceptions;

namespace DependencyInjection.Registration.Collectio.Attributes
{
    public abstract class AbstractRegistrationAttribute : Attribute
    {
        private const string RegistrationTargetErrorMessage = "Registration target must be an interface or a class";

        public Type RegistrationTarget { get; }

        protected AbstractRegistrationAttribute(Type registrationTarget)
        {
            if (IsInvalidRegistrationTarget(registrationTarget))
            {
                throw new IllegalRegistrationTargetException(RegistrationTargetErrorMessage);
            }

            RegistrationTarget = registrationTarget;
        }

        private bool IsValidRegistrationTarget(Type registrationTarget)
        {
            return (registrationTarget.IsInterface || registrationTarget.IsClass)
                && !registrationTarget.IsEnum 
                && !registrationTarget.IsArray 
                && !registrationTarget.IsPrimitive
                && !registrationTarget.IsSealed;
        }

        private bool IsInvalidRegistrationTarget(Type registrationTarget)
        {
            return !IsValidRegistrationTarget(registrationTarget);
        }
    }
}
