using ConsoleApp5.Abstract;
using ConsoleApp5.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<Form1>();
            services.AddScoped<IFilmService, FilmManager>();
            services.AddScoped<IYonetmenService, YonetmenManager>();
            services.AddDbContext<SinamaDbContext>();
            services.AddScoped<DbContext, SinamaDbContext>();

            var provider = services.BuildServiceProvider();



            Application.Run(provider.GetRequiredService<Form1>());
        }
    }
}