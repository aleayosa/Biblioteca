using Biblioteca.Entidades;
using Biblioteca.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.InterfazForm
{
    public partial class FrmEjemplares : Form
    {
        private EjemplarNegocio _ejemplarNegocio;
        private LibroNegocio _libroNegocio;
        private Validaciones _validaciones;

        public FrmEjemplares(Form padre)
        {
            InitializeComponent();
            _ejemplarNegocio = new EjemplarNegocio();
            _libroNegocio = new LibroNegocio();
            _validaciones = new Validaciones();
            this.Owner = padre; 
        }

        private void AltaEjemplar(int libro, string observaciones, int precio)
        {
            _ejemplarNegocio.Alta(libro, observaciones, precio);

        }

        private void MostrarEjemplares()
        {
            try
            {
                string ejemplares = string.Empty;

                List<Ejemplar> listado = _ejemplarNegocio.GetLista();
                List<Libro> lib = _libroNegocio.GetLista();

                _dataGridEjemplares.Rows.Clear();
                foreach (Ejemplar e in listado)
                {
                    int n = _dataGridEjemplares.Rows.Add();

                    foreach (Libro a in lib)
                        if (e.IdLibro == a.Id)
                        {
                            _dataGridEjemplares.Rows[n].Cells[1].Value = a.Titulo;
                        }
                    _dataGridEjemplares.Rows[n].Cells[0].Value = e.Id;
                    _dataGridEjemplares.Rows[n].Cells[2].Value = e.Precio;
                    _dataGridEjemplares.Rows[n].Cells[3].Value = e.Observaciones;


                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar los ejemplares: " + ex.Message);
            }

        }
        private void _btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                AltaEjemplar(int.Parse(_cmbLibros.SelectedValue.ToString()), _inputObservaciones.Text, int.Parse(_inputPrecio.Text)); ;
                MessageBox.Show("Se ha generado el nuevo ejemplar");
                Limpiar();
                MostrarEjemplares();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar alta el ejemplar: " + ex.Message);
            }
        }

        private void Validar()
        {
            if (!_validaciones.ValidarNull(_cmbLibros.Text))
                throw new Exception("El campo " + _lblLibro.Text + " no puede estar vacío");              
            _inputObservaciones.Text = _validaciones.ValidarString(_inputObservaciones.Text, _lblObservaciones.Text);
            _inputPrecio.Text = _validaciones.ValidarDouble(_inputPrecio.Text, _lblPrecio.Text, 1, 99999999999.99).ToString();
        }

        private void Limpiar()
        {
            _cmbLibros.Text = string.Empty;
            _inputObservaciones.Text = string.Empty;
            _inputPrecio.Text = string.Empty;

        }

        private void FrmEjemplares_Load(object sender, EventArgs e)
        {
            CargarLista();
            MostrarEjemplares();
        }

        private void _btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void CargarLista()
        {
            List<Libro> listadoLibros = _libroNegocio.GetLista();

            _cmbLibros.DataSource = null;
            _cmbLibros.DataSource = listadoLibros;
            _cmbLibros.DisplayMember = "ComboDisplay";
            _cmbLibros.ValueMember = "Id";

            Limpiar();

        }
    }
}
