using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSeminarioTema1.Entidades
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; } = null!;
        public string Sinopsis { get; set; }=null!;
        public int GeneroId { get; set; }

        public Genero? Genero { get; set; }

    }
}
