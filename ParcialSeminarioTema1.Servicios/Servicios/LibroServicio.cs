using AutoMapper;
using ParcialSeminarioTema1.Datos.Interfaces;
using ParcialSeminarioTema1.Entidades;
using ParcialSeminarioTema1.Entidades.DTOs.Libro;
using ParcialSeminarioTema1.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSeminarioTema1.Servicios.Servicios
{
    public class LibroServicio:ILibroServicio
    {
        private readonly ILibroRepositorio _libroRepositorio;
        private readonly IMapper _mapper;
        public LibroServicio(ILibroRepositorio libroRepositorio, IMapper mapper)
        {
            _libroRepositorio=libroRepositorio;
            _mapper=mapper;
            
        }

        public Libro? GetById(int libroId)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            return _libroRepositorio.GetCantidad();
        }

        public List<LibroListDto> GetLibros(int? generoId = null, string? textoFiltro = null)
        {
            var libros = _libroRepositorio.GetLibros(generoId, textoFiltro);
            return _mapper.Map<List<LibroListDto>>(libros);
        }

        public bool Guardar(Libro libro, out List<string> errores)
        {
            errores = new List<string>();
            //if (_libroRepositorio.Existe(libro))
            //{
            //    errores.Add("Libro existente");
            //    return false;
            //}
            if (libro.LibroId == 0)
            {
                _libroRepositorio.Agregar(libro);
                return true;
            }
            //_libroRepositorio.Editar(libro);
            return true;
        }
    }
}
