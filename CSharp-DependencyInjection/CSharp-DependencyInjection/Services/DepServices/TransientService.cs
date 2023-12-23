namespace CSharp_DependencyInjection.Services.DepServices
{
    public class TransientService
    {
        public string Value { get; }

        public TransientService()
        {

            Value = Guid.NewGuid().ToString();

        }
    }
}
