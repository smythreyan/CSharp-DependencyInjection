namespace CSharp_DependencyInjection.Services.DepServices
{
    public class ScopedService
    {
        public string Value { get; }

        public ScopedService()
        {

            Value = Guid.NewGuid().ToString();

        }

    }
}
