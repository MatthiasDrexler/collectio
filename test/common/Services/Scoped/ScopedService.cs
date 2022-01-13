namespace DependencyInjection.Registration.Collectio.Common.Services.Scoped
{
    internal class ScopedService : IScopedService
    {
        private int _value;
        
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