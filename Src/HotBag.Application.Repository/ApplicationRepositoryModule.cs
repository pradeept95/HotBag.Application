using HotBag.AspNetCore.Modules;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotBag.Application.Repository
{
    public class ApplicationRepositoryModule : ApplicationModule
    {
        public override string ModuleName => "ApplicationRepositoryModule";

        public override void Initialize(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            base.Initialize(serviceCollection, configuration);
        }
    }
}
