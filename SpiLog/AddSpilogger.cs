using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpiLog
{
   public static class SpiloggerEx
    {
        public static IServiceCollection AddSpilogger(this IServiceCollection services)
        {
            services.AddSingleton<ISpiloggerService,LoggerService>();
            //services.AddSingleton<ISpiloggerService, LoggerService>();
            return services;
        }
    }
}
