namespace DependencyInjection.Registration.Collectio.Common.Services.Transient
{
    internal class TransientService : ITransientService
    {
        private int _value;

        public TransientService()
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