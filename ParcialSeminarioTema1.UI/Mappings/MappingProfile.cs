using AutoMapper;
using ParcialSeminarioTema1.Entidades;
using ParcialSeminarioTema1.Entidades.DTOs.Genero;
using ParcialSeminarioTema1.Entidades.DTOs.Libro;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSeminarioTema1.UI.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            LoadGeneroMapping();
            LoadLibroMapping();
        }

        private void LoadLibroMapping()
        {
            CreateMap<Libro, LibroListDto>()
                .ForMember(l => l.NombreGenero, opt => opt.MapFrom(src => src.Genero!.NombreGenero));
        }

        private void LoadGeneroMapping()
        {
            CreateMap<Genero, GeneroListDto>();
            CreateMap<Genero, GeneroEditDto>().ReverseMap();
            CreateMap<GeneroEditDto, GeneroListDto>();
        }
    }
}
