using ParcialSeminarioTema1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSeminarioTema1.Datos.Interfaces
{
    public interface IGeneroRepositorio
    {
        List<Genero> GetGenero(string? textoParaFiltrar = null);
    }
}
