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
    public class GeneroRepositorioEF : IGeneroRepositorio
    {
        private readonly BibliotecaDbContext _dbContext;
        public GeneroRepositorioEF(BibliotecaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Genero> GetGenero(string? textoParaFiltrar = null)
        {
            return textoParaFiltrar is null ?
                _dbContext.Generos.AsNoTracking().ToList()
                : _dbContext.Generos.Where(p => p.NombreGenero
                .StartsWith(textoParaFiltrar)).AsNoTracking().ToList();
        }
    }
}
