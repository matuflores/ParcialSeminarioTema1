using ParcialSeminarioTema1.Entidades;
using ParcialSeminarioTema1.Entidades.DTOs.Libro;
using ParcialSeminarioTema1.Servicios.Interfaces;
using ParcialSeminarioTema1.UI.Helpers;

namespace ParcialSeminarioTema1.UI
{
    public partial class FrmBiblioteca : Form
    {
        private readonly ILibroServicio _libroServicio;
        private readonly IGeneroServicio _generoServicio;
        //private List<GeneroListDto>? _genero;
        private List<LibroListDto>? _libro;
        //private bool filtrarOn = false;
        public FrmBiblioteca(ILibroServicio libroServicio, IGeneroServicio generoServicio)//, IGeneroServicio generoServicio)
        {
            InitializeComponent();
            _libroServicio = libroServicio;
            _generoServicio = generoServicio;
        }

        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
            try
            {
                //_genero = _generoServicio.GetGenero();
                //pruebaGIT
                _libro = _libroServicio.GetLibros();
                int cantidadLibros = _libroServicio.GetCantidad();
                TxtRegistros.Text = cantidadLibros.ToString();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (var libro in _libro!)
            {
                var r = GridHelper.ConstruirFila(dgvDatos);

                GridHelper.SetearFila(r, libro);
                GridHelper.AgregarFila(r, dgvDatos);
            }
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            FrmLibrosAE frm = new FrmLibrosAE(_generoServicio) { Text = "Nueva Provincia/Estado" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Libro? libro = frm.GetLibro();
            if (libro is null) return;

            //try
            //{
            //    if (_libroServicio.Guardar(provinciaEstado, out var errores))//(_provinciaEstadoServicio.Existe(provinciaEstado))
            //    {
            //        ProvinciaEstado? peAgregado = _provinciaEstadoServicio.GetById(provinciaEstado.ProvinciaEstadoId);
            //        DataGridViewRow r = GridHelper.ConstruirFila(dgvProvEst);
            //        GridHelper.SetearFila(r, peAgregado!);
            //        GridHelper.AgregarFila(r, dgvProvEst);
            //        MessageBox.Show("Provincia/Estado Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show(errores.First(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
    }
}
