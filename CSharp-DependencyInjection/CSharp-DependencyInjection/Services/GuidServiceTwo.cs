using CSharp_DependencyInjection.Services.DepServices;

namespace CSharp_DependencyInjection.Services
{
    public class GuidServiceTwo(
        SingletonService singleton,
        ScopedService scoped,
        TransientService transient
        )
    {
        public List<string> GetGuid()
        {
            List<string> strs = [];

            strs.Add($"{nameof(singleton)} : {singleton.Value}");
            strs.Add($"{nameof(scoped)} : {scoped.Value}");
            strs.Add($"{nameof(transient)} : {transient.Value}");

            return strs;
        }
    }
}
