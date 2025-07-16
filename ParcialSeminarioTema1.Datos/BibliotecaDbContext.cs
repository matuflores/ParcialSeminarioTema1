using Microsoft.EntityFrameworkCore;
using ParcialSeminarioTema1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSeminarioTema1.Datos
{
    public class BibliotecaDbContext:DbContext
    {
        public BibliotecaDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public BibliotecaDbContext()
        {
            
        }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}
