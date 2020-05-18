using HotBag.AspNetCore.AppSettings;
using HotBag.AspNetCore.Modules;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotBag.Application.Host
{
    public class ApplicationHostModule : ApplicationModule
    {
        public override string ModuleName => "ApplicationHostModule";

        public override void Initialize(IServiceCollection serviceCollection, IConfiguration configuration)
        { 
            HotBagConfiguration.Configurations.ApplicationSettings.Features.IsEnableSwaggerApiDoc = true;
            HotBagConfiguration.Configurations.ApplicationSettings.SentDetailExceptionMessage = false;

            base.Initialize(serviceCollection, configuration);

        }
    }
}
