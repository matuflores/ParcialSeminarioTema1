using ParcialSeminarioTema1.Entidades;
using ParcialSeminarioTema1.Entidades.DTOs.Libro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSeminarioTema1.Servicios.Interfaces
{
    public interface ILibroServicio
    {
        Libro? GetById(int libroId);
        List<LibroListDto> GetLibros(int? generoId = null, string? textoFiltro = null);
        bool Guardar(Libro libro, out List<string> errores);
        int GetCantidad();
    }
}
