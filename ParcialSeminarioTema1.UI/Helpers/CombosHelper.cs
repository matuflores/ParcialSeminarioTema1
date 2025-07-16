using ParcialSeminarioTema1.Entidades.DTOs.Genero;
using ParcialSeminarioTema1.Servicios.Interfaces;
using ParcialSeminarioTema1.Servicios.Servicios;

namespace ParcialSeminarioTema1.UI.Helpers
{
    public static class CombosHelper
    {
        public static void CargarComboGeneros(ref ComboBox cbo, IGeneroServicio generoServicio)
        {
            var listaGeneros = generoServicio.GetGenero();
            var defaultGenero = new GeneroListDto
            {
                GeneroId = 0,
                NombreGenero = "Selecione País"
            };
            listaGeneros.Insert(0, defaultGenero);
            cbo.DataSource = listaGeneros;
            cbo.DisplayMember = "NombreGenero";
            cbo.ValueMember = "GeneroId";
            cbo.SelectedIndex = 0;
        }

    }
}
