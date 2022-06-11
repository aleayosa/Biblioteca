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
    public partial class FrmPrestamos : Form
    {
        private PrestamoNegocio _prestamoNegocio;
        private LibroNegocio _libroNegocio;
        private ClienteNegocio _clienteNegocio;
        private EjemplarNegocio _ejemplarNegocio;
        public FrmPrestamos()
        {
            InitializeComponent();

            _prestamoNegocio = new PrestamoNegocio();
            _libroNegocio = new LibroNegocio();
            _clienteNegocio = new ClienteNegocio();
            _ejemplarNegocio = new EjemplarNegocio();
        }


        private void _btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    AltaPrestamo(int.Parse(_inputidCliente.Text), int.Parse(_inputIdEjemplar.Text), int.Parse(_inputPlazo.Text));
                    MessageBox.Show("Se ha generado el nuevo préstamo");
                    Limpiar();
                    MostrarPrestamo();
                }
                else
                {
                    MessageBox.Show("Hay campos incompletos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar alta el préstamo: " + ex.Message);
            }

        }
        private void AltaPrestamo(int idCliente, int idEjemplar, int plazo)
        {
            _prestamoNegocio.Alta(idCliente, idEjemplar, plazo);

        }

        private void MostrarPrestamo()
        {
            try
            {
                string prestamo = string.Empty;

                List<Libro> listadoLibros = _libroNegocio.GetLista();
                List<Cliente> listadoClientes = _clienteNegocio.GetLista();
                List<Prestamo> listadoPrestamo = _prestamoNegocio.GetLista();
                List<Ejemplar> listadoEjemplares = _ejemplarNegocio.GetLista();

                _dataGridPrestamos.Rows.Clear();
                foreach (Prestamo p in listadoPrestamo)
                {
                    for (var i = 0; i < listadoEjemplares.Count; i++)
                    {
                        if (listadoEjemplares[i].Id == p.IdEjemplar)
                        {
                            for (var j = 0; j < listadoLibros.Count; j++)
                            {
                                if (listadoLibros[j].Id == listadoEjemplares[i].IdLibro)
                                {

                                    int n = _dataGridPrestamos.Rows.Add();
                                    _dataGridPrestamos.Rows[n].Cells[0].Value = p.Id;
                                    foreach (Cliente c in listadoClientes)
                                    {
                                        if (c.Id == p.IdCliente)
                                            _dataGridPrestamos.Rows[n].Cells[1].Value = c.Apellido + ", " + c.Nombre;
                                    }
                                    _dataGridPrestamos.Rows[n].Cells[2].Value = p.IdEjemplar;
                                    _dataGridPrestamos.Rows[n].Cells[3].Value = listadoLibros[j].Titulo;
                                    _dataGridPrestamos.Rows[n].Cells[4].Value = listadoLibros[j].Autor;
                                    _dataGridPrestamos.Rows[n].Cells[5].Value = p.FechaPrestamo;
                                    _dataGridPrestamos.Rows[n].Cells[6].Value = p.FechaDevolucionTentativa;
                                    _dataGridPrestamos.Rows[n].Cells[7].Value = p.FechaDevolucionReal;


                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar los préstamos: " + ex.Message);
            }
        }
        private bool Validar()
        {
            if (string.IsNullOrEmpty(_inputidCliente.Text))
                return false;
            if (string.IsNullOrEmpty(_inputIdEjemplar.Text))
                return false;
            if (string.IsNullOrEmpty(_inputPlazo.Text))
                return false;

            return true;
        }

        private void Limpiar()
        {
            _inputidCliente.Text = string.Empty;
            _inputIdEjemplar.Text = string.Empty;
            _inputPlazo.Text = string.Empty;
        }

        private void _btnVolver3_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmBiblioteca frm4 = new FrmBiblioteca();

            frm4.Show();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            MostrarPrestamo();
        }

        private void _btnEliminarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                List<Prestamo> listadoPrestamo = _prestamoNegocio.GetLista();

                foreach (Prestamo p in listadoPrestamo)
                {
                    if (p.Id == int.Parse(_inputIdPrestamoEliminar.Text))
                    {
                        _prestamoNegocio.Eliminar(p);
                    }
                }

                MostrarPrestamo();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar el préstamo: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Prestamo> listadoPrestamo = _prestamoNegocio.GetLista();

                foreach (Prestamo p in listadoPrestamo)
                {
                    if (p.Id == int.Parse(_inputIdFinalizado.Text))
                    {
                        Prestamo p2 = new Prestamo();
                        p2 = p;
                        p2.FechaDevolucionReal = DateTime.Now;
                        _prestamoNegocio.Modificar(p2);
                    }
                }

                MostrarPrestamo();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar el préstamo: " + ex.Message);
            }
        }
    }
}
