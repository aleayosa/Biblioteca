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
    public partial class FrmReportesEXL : Form
    {
        private EjemplarNegocio _ejemplarNegocio;
        private LibroNegocio _libroNegocio;

        public FrmReportesEXL()
        {
            InitializeComponent();
            _ejemplarNegocio = new EjemplarNegocio();
            _libroNegocio = new LibroNegocio();
        }

        private void _btnExL_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {

                    _lblNombreLibro.Text = _cmbLibroE.Text;
                    List<Ejemplar> listadoEjemplar = _ejemplarNegocio.GetLista();

                    _dataGridReporteEjemplares.Rows.Clear();
                    foreach (Ejemplar a in listadoEjemplar)
                    {
                        if (a.IdLibro == int.Parse(_cmbLibroE.SelectedValue.ToString()))
                        {
                            int n = _dataGridReporteEjemplares.Rows.Add();
                            _dataGridReporteEjemplares.Rows[n].Cells[0].Value = a.Id;
                            _dataGridReporteEjemplares.Rows[n].Cells[1].Value = a.FechaAlta;
                            _dataGridReporteEjemplares.Rows[n].Cells[2].Value = a.Precio;
                            _dataGridReporteEjemplares.Rows[n].Cells[3].Value = a.Observaciones;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El campo Id Libro no puede quedar vacío");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar libro" + ex.Message);
            }
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(_cmbLibroE.Text))
                return false;

            return true;
        }


        private void _btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmBiblioteca frm3 = new FrmBiblioteca();

            frm3.Show();
        }

        private void CargarLista()
        {
            List<Libro> listadoLibros = _libroNegocio.GetLista();

            _cmbLibroE.DataSource = null;
            _cmbLibroE.DataSource = listadoLibros;
            _cmbLibroE.DisplayMember = "ComboDisplay";
            _cmbLibroE.ValueMember = "Id";

        }

        private void FrmReportesEXL_Load(object sender, EventArgs e)
        {
            CargarLista();
        }
    }
}

