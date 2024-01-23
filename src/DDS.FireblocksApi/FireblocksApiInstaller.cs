using System.Net.Http.Headers;
using DDS.FireblocksApi.Configuration;
using DDS.FireblocksApi.Handlers;
using DDS.Utils.Http.Handlers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace DDS.FireblocksApi
{
    public static class FireblocksApiInstaller
    {
        public static IServiceCollection AddFireblocksApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            var section = configuration.GetSection(FireblocksSettings.SectionName);
            services.Configure<FireblocksSettings>(section);
            services.Configure<FireblocksWebHooksSettings>(section.GetSection(nameof(FireblocksSettings.WebHooks)));

            services.AddTransient<AuthorizationMessageHandler>();

            services
                .AddHttpClient<IFireblocksClient, FireblocksClient>()
                .ConfigureHttpClient((sp, http) =>
                {
                    var options = sp.GetRequiredService<IOptions<FireblocksSettings>>();
                    http.BaseAddress = new Uri(options.Value.BaseUrl);
                    http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    http.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("utf-8"));
                })
                .AddHttpMessageHandler(sp => sp.GetRequiredService<AuthorizationMessageHandler>())
                .AddHttpMessageHandler(sp => sp.GetRequiredService<RequestIdMessageHandler>())
                .AddHttpMessageHandler(sp => sp.GetRequiredService<LogMessageHandler>());

            return services;
        }
    }
}
