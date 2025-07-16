using ParcialSeminarioTema1.Entidades;
using ParcialSeminarioTema1.Servicios.Interfaces;
using ParcialSeminarioTema1.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialSeminarioTema1.UI
{
    public partial class FrmLibrosAE : Form
    {
        private Libro? _libro;
        private readonly IGeneroServicio _generoServicio;
        public FrmLibrosAE(IGeneroServicio generoServicio)
        {
            InitializeComponent();
            _generoServicio = generoServicio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (_libro is null)
                {
                    _libro = new Libro();
                }
                _libro.Titulo = TxtTitulo.Text;
                _libro.Sinopsis = TxtSinopsis.Text;
                _libro.GeneroId = (int)CboGeneros.SelectedValue!;
                //aca le paso el PAIS id, pero tengo que mostrar el nombre en la grilla


                //_provinciaEstado.Pais=(Pais)cbPaisProvEst.SelectedItem!;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TxtTitulo.Text))
            {
                valido = false;
                errorProvider1.SetError(TxtTitulo, "El Titulo es requerido");
            }
            if (CboGeneros.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(CboGeneros, "Debe seleccionar un genero");
            }

            return valido;
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    CombosHelper.CargarComboGeneros(ref CboGeneros, _paisServicio);
        //    if (_provinciaEstado is not null)
        //    {
        //        textBoxProvEst.Text = _provinciaEstado.NombreProvinciaEstado;

        //        //Si no me aparece el pais correspondiente a la prov/est es porque el select
        //        //no es el que corresponde, antes tenia SELECTEINDEX y no era correcto el pais que
        //        //me cargaba el cbPaisProvEst
        //        cbPaisProvEst.SelectedValue = _provinciaEstado.PaisId;
        //    }
        //}
        private void FrmLibrosAE_Load(object sender, EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboGeneros(ref CboGeneros, _generoServicio);
            //if (_generoServicio is not null)
            //{
            //    textBoxProvEst.Text = _provinciaEstado.NombreProvinciaEstado;

            //    //Si no me aparece el pais correspondiente a la prov/est es porque el select
            //    //no es el que corresponde, antes tenia SELECTEINDEX y no era correcto el pais que
            //    //me cargaba el cbPaisProvEst
            //    cbPaisProvEst.SelectedValue = _provinciaEstado.PaisId;
            //}
        }

        internal Libro? GetLibro()
        {
            throw new NotImplementedException();
        }
    }
}
