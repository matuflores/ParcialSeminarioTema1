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

        public void Agregar(Libro libro)
        {
            _dbContext.Libros.Add(libro);
            _dbContext.SaveChanges();
        }

        //public bool Existe(Libro libro)
        //{
        //    var libroEnDn = GetById(libro.LibroId);
        //    if (libroEnDn is not null)
        //    {
        //        //CUANDO QUERIA GUARDAR LA EDICION SALIO UN ERROR QUE SE ME MODIFICABA PERO NO ME 
        //        //VOLVIA A MOSTRAR LA LISTA! es porque me esta guardando tambien el PAIS!
        //        libroEnDn.Titulo = libro.Titulo;
        //        provEstEnDb.PaisId = provinciaEstado.PaisId;
        //        provEstEnDb.Pais = null;//con esto lo anulo y no se guarda!!
        //        _dbContext.Entry(provEstEnDb).State = EntityState.Modified;
        //        _dbContext.SaveChanges();
        //    }
        //}

        public Libro? GetById(int libroId)
        {
            return _dbContext.Libros
                .Include(l => l.GeneroId)
                .AsNoTracking()
                .FirstOrDefault(l => l.LibroId == libroId);
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
