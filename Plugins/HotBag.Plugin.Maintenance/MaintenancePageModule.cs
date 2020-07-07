using HotBag.AspNetCore.AppSettings;
using HotBag.AspNetCore.Modules;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotBag.Plugin.Maintenance
{
    public class MaintenancePageModule : ApplicationModule
    {
        public override string ModuleName => "Plugin.MaintenancePage";

        public override void Initialize(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            //It enables the maintenance Mode
            MaintenanceConfig.DisableMaintenanceMode();


            base.Initialize(serviceCollection, configuration);
        }
    }

}
