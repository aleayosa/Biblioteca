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
        private Validaciones _validaciones;
        public FrmPrestamos(Form padre)
        {
            InitializeComponent();

            _prestamoNegocio = new PrestamoNegocio();
            _libroNegocio = new LibroNegocio();
            _clienteNegocio = new ClienteNegocio();
            _ejemplarNegocio = new EjemplarNegocio();
            _validaciones = new Validaciones();
            this.Owner = padre;
        }


        private void _btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                AltaPrestamo(int.Parse(_cmbClientes.SelectedValue.ToString()), int.Parse(_cmbEjemplares.SelectedValue.ToString()), int.Parse(_inputPlazo.Text));
                MessageBox.Show("Se ha generado el nuevo préstamo");
                Limpiar();
                MostrarPrestamo();
                CargarLista();
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
        private void Validar()
        {
            if (!_validaciones.ValidarNull(_cmbClientes.Text))
                throw new Exception("El campo " + _lblClienteP.Text + " no puede estar vacío");
            if (!_validaciones.ValidarNull(_cmbEjemplares.Text))
                throw new Exception("El campo " + _lblEjemplarP.Text + " no puede estar vacío");
            _inputPlazo.Text = _validaciones.ValidarInt(_inputPlazo.Text, _lblPlazo.Text, 1, 365).ToString();
        }

        private void Limpiar()
        {
            _cmbClientes.Text = string.Empty;
            _cmbEjemplares.Text = string.Empty;
            _inputPlazo.Text = string.Empty;
            _cmbIdEliminar.Text = string.Empty;
            _cmbIdFinalizar.Text = string.Empty;
        }

        private void _btnVolver3_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            CargarLista();
            MostrarPrestamo();
        }

        private void CargarLista()
        {
            List<Cliente> listadoClientes = _clienteNegocio.GetLista();

            _cmbClientes.DataSource = null;
            _cmbClientes.DataSource = listadoClientes;
            _cmbClientes.DisplayMember = "ComboDisplay";
            _cmbClientes.ValueMember = "Id";

            List<Ejemplar> listadoEjemplares = _ejemplarNegocio.GetLista();

            _cmbEjemplares.DataSource = null;
            _cmbEjemplares.DataSource = listadoEjemplares;
            _cmbEjemplares.DisplayMember = "Id";
            _cmbEjemplares.ValueMember = "Id";

            List<Prestamo> listadoPrestamos = _prestamoNegocio.GetLista();

            _cmbIdEliminar.DataSource = null;
            _cmbIdEliminar.DataSource = listadoPrestamos;
            _cmbIdEliminar.DisplayMember = "Id";
            _cmbIdEliminar.ValueMember = "Id";

            List<Prestamo> listadoPrestamos2 = _prestamoNegocio.GetLista();
            _cmbIdFinalizar.DataSource = null;
            _cmbIdFinalizar.DataSource = listadoPrestamos2;
            _cmbIdFinalizar.DisplayMember = "Id";
            _cmbIdFinalizar.ValueMember = "Id";

            Limpiar();
        }
        private void _btnEliminarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_validaciones.ValidarNull(_cmbIdEliminar.Text))
                    throw new Exception("El campo ID no puede estar vacío");
                List<Prestamo> listadoPrestamo = _prestamoNegocio.GetLista();

                foreach (Prestamo p in listadoPrestamo)
                {
                    if (p.Id == int.Parse(_cmbIdEliminar.SelectedValue.ToString()))
                    {
                        _prestamoNegocio.Eliminar(p);
                    }
                }

                MostrarPrestamo();
                CargarLista();
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
                if (!_validaciones.ValidarNull(_cmbIdFinalizar.Text))
                    throw new Exception("El campo ID no puede estar vacío");
                List<Prestamo> listadoPrestamo = _prestamoNegocio.GetLista();

                foreach (Prestamo p in listadoPrestamo)
                {
                    if (p.Id == int.Parse(_cmbIdFinalizar.SelectedValue.ToString()))
                    {
                        Prestamo p2 = new Prestamo();
                        p2 = p;
                        if(p2.FechaDevolucionReal != Convert.ToDateTime("1/1/0001"))
                        {
                            throw new Exception("El préstamo seleccionado ya fue finalizado con fecha: "+p2.FechaDevolucionReal+".");
                        }
                        p2.FechaDevolucionReal = DateTime.Now;
                        _prestamoNegocio.Modificar(p2);
                    }
                }

                MostrarPrestamo();
                CargarLista();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al finalizar el préstamo: " + ex.Message);
            }
        }

    }
}
