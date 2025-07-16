using ParcialSeminarioTema1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSeminarioTema1.Datos.Interfaces
{
    public interface ILibroRepositorio
    {
        List<Libro> GetLibros(int? generoId = null, string? textoFiltro = null);
        void Agregar(Libro libro);
        //bool Existe(Libro libro);
        Libro? GetById(int libroId);
        int GetCantidad();
    }
}
