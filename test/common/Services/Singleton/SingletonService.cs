using DependencyInjection.Registration.Collectio.Attributes;

namespace DependencyInjection.Registration.Collectio.Common.Services.Singleton
{
    [Singleton(typeof(ISingletonService))]
    internal class SingletonService : ISingletonService
    {
        private int _value;

        public SingletonService()
        {
            _value = 1;
        }

        public int GetValue()
        {
            return _value;
        }

        public int SetValue(int value)
        {
            _value = value;
            return _value;
        }
    }
}
