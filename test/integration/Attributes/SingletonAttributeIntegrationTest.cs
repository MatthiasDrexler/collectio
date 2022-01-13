using System.Reflection;
using DependencyInjection.Registration.Collectio.Attributes;
using DependencyInjection.Registration.Collectio.Common.Services.Singleton;
using FluentAssertions;
using NUnit.Framework;

namespace DependencyInjection.Registration.Collectio.IntegrationTests.Attributes
{
    [TestFixture]
    internal class SingletonAttributeIntegrationTest : AbstractIntegrationTest
    {
        private SingletonService? _singletonService;

        [SetUp]
        public void SetUp()
        {
            _singletonService = new SingletonService();
        }
        
        [Test]
        public void WhenClassAnnotated_ShouldBeSingleton()
        {
            var attribute = _singletonService?.GetType().GetCustomAttribute<SingletonAttribute>();

            attribute.Should().NotBeNull();
        }

        [Test]
        public void WhenClassAnnotatedWithAnotherAttribute_ShouldNotBeSingleton()
        {
            var attribute = _singletonService?.GetType().GetCustomAttribute<CategoryAttribute>();

            attribute.Should().BeNull();
        }
    }
}
