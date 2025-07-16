using Microsoft.EntityFrameworkCore;
using ParcialSeminarioTema1.Datos.Interfaces;
using ParcialSeminarioTema1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSeminarioTema1.Datos.Repositorios
{
    public class LibroRepositorioEF : ILibroRepositorio
    {
        private readonly BibliotecaDbContext _dbContext;
        public LibroRepositorioEF(BibliotecaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int GetCantidad()
        {
            return _dbContext.Libros.Count();
        }

        public List<Libro> GetLibros(int? generoId = null, string? textoParaFiltrar = null)
        {
            IQueryable<Libro> query = _dbContext.Libros
                .Include(l => l.Genero).AsNoTracking();

            if (generoId.HasValue)
            {
                query = query.Where(g => g.GeneroId == generoId.Value);
            }
            if (!string.IsNullOrEmpty(textoParaFiltrar))
            {
                query = query.Where(g => g.Genero!.NombreGenero.Contains(textoParaFiltrar) ||
                g.Titulo.Contains(textoParaFiltrar));
            }
            return query.ToList();
        }
    }
}
