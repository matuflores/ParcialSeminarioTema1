using ParcialSeminarioTema1.Entidades.DTOs.Libro;
using ParcialSeminarioTema1.Servicios.Interfaces;
using ParcialSeminarioTema1.UI.Helpers;

namespace ParcialSeminarioTema1.UI
{
    public partial class FrmBiblioteca : Form
    {
        private readonly ILibroServicio _libroServicio;
        //private readonly IGeneroServicio _generoServicio;
        //private List<GeneroListDto>? _genero;
        private List<LibroListDto>? _libro;
        //private bool filtrarOn = false;
        public FrmBiblioteca(ILibroServicio libroServicio)//, IGeneroServicio generoServicio)
        {
            InitializeComponent();
            _libroServicio = libroServicio;
            //_generoServicio = generoServicio;
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
                _libro = _libroServicio.GetLibros();
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
    }
}
