namespace CSharp_DependencyInjection.Services.DepServices
{
    public class SingletonService
    {
        public string Value { get; }

        public SingletonService()
        {

            Value = Guid.NewGuid().ToString();

        }
    }
}
