using System;
using DependencyInjection.Registration.Collectio.Attributes;
using DependencyInjection.Registration.Collectio.Common.Services.Singleton;
using DependencyInjection.Registration.Collectio.Exceptions;
using FluentAssertions;
using NUnit.Framework;

namespace DependencyInjection.Registration.Collectio.UnitTests.Attributes
{
    [TestFixture]
    internal class SingletonAttributeTest : AbstractUnitTest
    {
        [Test]
        public void WhenInterfaceGiven_ShouldStoreInterfaceInAttribute()
        {
            var singletonAttribute = new SingletonAttribute(typeof(ISingletonService));

            singletonAttribute.RegistrationTarget.FullName.Should().Contain("ISingletonService");
        }

        [Test]
        public void WhenClassGiven_ShouldStoreClassInAttribute()
        {
            var singletonAttribute = new SingletonAttribute(typeof(SingletonService));

            singletonAttribute.RegistrationTarget.FullName.Should().Contain("SingletonService");
        }

        [Test]
        public void WhenNeitherInterfaceNorClassGiven_ShouldThrowException()
        {
            Action constructWithNullAsRegistrationTarget = () =>
            {
                // ReSharper disable once UnusedVariable
                var constructedAttributeWithIllegalRegistrationTarget = new SingletonAttribute(new bool[] {}.GetType());
            };

            constructWithNullAsRegistrationTarget.Should().Throw<IllegalRegistrationTargetException>();
        }
    }
}
