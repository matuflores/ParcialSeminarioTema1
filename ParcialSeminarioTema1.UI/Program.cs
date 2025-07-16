using Microsoft.Extensions.DependencyInjection;
using ParcialSeminarioTema1.Servicios.Interfaces;
using ParcialSeminarioTema1.UI.Infraestructura;

namespace ParcialSeminarioTema1.UI
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
            AppServices.Inicializar();
            ILibroServicio libroServicio = AppServices.ServiceProvider
                .GetRequiredService<ILibroServicio>();
            IGeneroServicio generoServicio = AppServices.ServiceProvider
                .GetRequiredService<IGeneroServicio>();
            Application.Run(new FrmBiblioteca(libroServicio,generoServicio));
        }
    }
}