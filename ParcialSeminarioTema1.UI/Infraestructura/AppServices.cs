using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ParcialSeminarioTema1.Datos;
using ParcialSeminarioTema1.Datos.Interfaces;
using ParcialSeminarioTema1.Datos.Repositorios;
using ParcialSeminarioTema1.Servicios.Interfaces;
using ParcialSeminarioTema1.Servicios.Servicios;
using ParcialSeminarioTema1.UI.Mappings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSeminarioTema1.UI.Infraestructura
{
    public static class AppServices
    {
        private static IServiceProvider? _serviceProvider;
        public static void Inicializar()
        {
            var services = new ServiceCollection();

            services.AddDbContext<BibliotecaDbContext>(options =>
            {
                options.UseSqlServer(ConfigurationManager
                    .ConnectionStrings["MiConexion"].ConnectionString);

            });

            services.AddScoped<IGeneroRepositorio, GeneroRepositorioEF>();
            services.AddScoped<ILibroRepositorio, LibroRepositorioEF>();

            services.AddScoped<IGeneroServicio, GeneroServicio>();
            services.AddScoped<ILibroServicio, LibroServicio>();

            services.AddAutoMapper(typeof(MappingProfile).Assembly);

            _serviceProvider = services.BuildServiceProvider();
        }

        public static IServiceProvider? ServiceProvider =>
            _serviceProvider ?? throw new NotImplementedException("DEPENDENCIAS NO ESTABLECIDAS");

    }
}
