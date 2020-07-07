using HotBag.AspNetCore.AppSettings.Custom;
using HotBag.AspNetCore.DI;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks; 
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.IO;
using System.Reflection;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HotBag.Plugin.Maintenance.Middleware
{
    public class MaintenanceMiddleware
    {
        private readonly RequestDelegate _next;

        public MaintenanceMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            var customConfig = IocManager.Configurations.ServiceProvider.GetService<IDictionaryBasedConfig>();
            //customConfig.Set("TestKey", "MyValue");
            bool isMaintenanceEnable = customConfig.Get<bool>("IsApplicationInMaintenanceMode");

            if (!isMaintenanceEnable)
            { 
                await _next.Invoke(context);
            }
            else
            {
                var currentAssembly = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string Html = File.ReadAllText(Path.Combine(currentAssembly, "template.html"));
                StringBuilder sb = new StringBuilder(Html);
                await context.Response.WriteAsync(sb.ToString());
            } 
        }
    }
}
