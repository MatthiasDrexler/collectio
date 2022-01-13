using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace DependencyInjection.Registration.Collectio.IntegrationTests
{
    [Category("IntegrationTest")]
    internal class AbstractIntegrationTest
    {
        protected ServiceCollection? ServiceCollection;

        [SetUp]
        public void SetUpServer()
        {
            ServiceCollection = new ServiceCollection();
        }
    }
}
