using HotBag.AspNetCore.Modules;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotBag.Application.Core
{
    public class ApplicationCoreModule : ApplicationModule
    {
        public override string ModuleName => "ApplicationCoreModule";

        public override void Initialize(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            base.Initialize(serviceCollection, configuration);
        }
    }
}
