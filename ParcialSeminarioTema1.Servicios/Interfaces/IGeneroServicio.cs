using ParcialSeminarioTema1.Entidades.DTOs.Genero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSeminarioTema1.Servicios.Interfaces
{
    public interface IGeneroServicio
    {
        List<GeneroListDto> GetGenero(string? textoParaFiltrar = null);
    }
}
