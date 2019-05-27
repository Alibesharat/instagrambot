using InstagarmBot.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpiLog;


namespace InstagarmBot
{
    public static class ServicesExtention
    {
        /// <summary>
        /// تزریق اسپایگرام به برنامه
        /// </summary>
        /// <param name="services"></param>
        /// <param name="ConnentionString">رشته اتصال</param>
        /// <returns></returns>
        public static IServiceCollection AddInstagramBot(this IServiceCollection services, string ConnentionString)
        {
          
            services.AddDbContext<SpigramContext>(opt=>opt.UseSqlServer(ConnentionString).EnableSensitiveDataLogging(true));
            services.AddScoped<Bot>();
            services.AddSingleton<ISpiloggerService, LoggerService>();
           
            return services;
        }
    }

    
}
