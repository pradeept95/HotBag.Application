using HotBag.AspNetCore.AppSettings.Custom;
using HotBag.AspNetCore.DI;
using HotBag.Plugin.Maintenance.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace HotBag.Plugin.Maintenance
{
    public static class HotBagMaintenanceExtension
    {
        public static IApplicationBuilder UseHotBagMaintenance(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MaintenanceMiddleware>();
        }
    }

}
