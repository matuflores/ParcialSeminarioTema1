using AutoMapper;
using ParcialSeminarioTema1.Datos.Interfaces;
using ParcialSeminarioTema1.Entidades.DTOs.Genero;
using ParcialSeminarioTema1.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSeminarioTema1.Servicios.Servicios
{
    public class GeneroServicio : IGeneroServicio
    {
        private readonly IGeneroRepositorio _generoRepositorio;
        private readonly IMapper _mapper;
        public GeneroServicio(IGeneroRepositorio generoRepositorio, IMapper mapper)
        {
            _generoRepositorio= generoRepositorio;
            _mapper= mapper;
        }
        public List<GeneroListDto> GetGenero(string? textoParaFiltrar = null)
        {
            var generos = _generoRepositorio.GetGenero(textoParaFiltrar);
            return _mapper.Map<List<GeneroListDto>>(generos);
        }
    }
}
