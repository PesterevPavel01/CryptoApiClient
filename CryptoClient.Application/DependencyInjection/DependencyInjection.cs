using CryptoClient.App.Dto;
using CryptoClient.App.Interfaces.Services;
using CryptoClient.App.Models;
using CryptoClient.App.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoClient.App.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void InitServices(this IServiceCollection services)
        {
            services.AddScoped<ICryptoApiService, CriptoApiService>();
        }

    }
}
