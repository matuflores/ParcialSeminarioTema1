﻿using ParcialSeminarioTema1.Entidades.DTOs.Genero;
using ParcialSeminarioTema1.Entidades.DTOs.Libro;

namespace ParcialSeminarioTema1.UI.Helpers
{
    public static class GridHelper
    {
        /// <summary>
        /// Método estático para limpiar una grilla
        /// </summary>
        /// <param name="grid">Grilla que se desea limpiar</param>
        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        /// <summary>
        /// Método estático para construir una nueva fila
        /// de la grilla que me pasan
        /// </summary>
        /// <param name="grid">Grilla a la cual le creo la fila</param>
        /// <returns>Fila de la grilla resultante</returns>
        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }
        /// <summary>
        /// Método estático para setear la fila de la grilla
        /// con el contenido del objeto que me pasan
        /// </summary>
        /// <param name="r">Fila a popular</param>
        /// <param name="obj">objeto que se muestra</param>
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case GeneroListDto genero:
                    r.Cells[0].Value = genero.GeneroId;
                    r.Cells[1].Value = genero.NombreGenero;
                    break;
                case LibroListDto libro:
                    r.Cells[0].Value = libro.LibroId;
                    r.Cells[1].Value = libro.Titulo;
                    //r.Cells[2].Value = provinciaEstado.PaisId;
                    r.Cells[2].Value = libro.NombreGenero;
                    break;
            }

            r.Tag = obj;
        }
        /// <summary>
        /// Método estático para agregar una fila a una grilla
        /// </summary>
        /// <param name="r">Fila a agregar</param>
        /// <param name="grid">Grilla en la cual se agrega la fila</param>
        public static void AgregarFila(DataGridViewRow r, DataGridView grid)
        {
            grid.Rows.Add(r);
        }
        /// <summary>
        /// Método estático para eliminar una fila a una grilla
        /// </summary>
        /// <param name="r">Fila a eliminar</param>
        /// <param name="grid">Grilla en la cual se desea quitar la fila</param>
        public static void QuitarFila(DataGridViewRow r, DataGridView grid)
        {
            grid.Rows.Remove(r);
        }
    }
}
