using HotBag.AspNetCore.Modules;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotBag.Application.Service
{
    public class ApplicationServiceModule : ApplicationModule
    {
        public override string ModuleName => "ApplicationServiceModule";

        public override void Initialize(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            base.Initialize(serviceCollection, configuration);
        }
    }

}
