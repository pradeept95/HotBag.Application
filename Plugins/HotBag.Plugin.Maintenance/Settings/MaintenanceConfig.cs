using HotBag.AspNetCore.AppSettings.Custom;
using HotBag.AspNetCore.DI;
using Microsoft.Extensions.DependencyInjection;

namespace HotBag.Plugin.Maintenance
{
    public static class MaintenanceConfig
    { 
        public static void EnableMaintenanceMode()
        {
            var maintenanceConfig = IocManager.Configurations.ServiceProvider.GetService<IDictionaryBasedConfig>();
            maintenanceConfig.Set("IsApplicationInMaintenanceMode", true);
        } 
      
        public static void DisableMaintenanceMode()
        {
            var maintenanceConfig = IocManager.Configurations.ServiceProvider.GetService<IDictionaryBasedConfig>();
            maintenanceConfig.Set("IsApplicationInMaintenanceMode", false);
        } 
    }
}
