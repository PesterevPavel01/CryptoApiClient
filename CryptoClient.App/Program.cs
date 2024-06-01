using CryptoClient.App.Dto;
using CryptoClient.App.DependencyInjection;
using CryptoClient.App.Interfaces.Services;
using CryptoClient.App.Models;
using CryptoClient.App.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CryptoClient.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IHost? HostContainer { get; private set; }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            var builder = Host.CreateDefaultBuilder();

            builder.ConfigureServices((context, services) =>
            {
                services.AddTransient<MainForm>();
                services.InitServices();
            }
            );

            HostContainer = builder.Build();

            Application.Run(HostContainer.Services.GetRequiredService<MainForm>());
        }

    }
}