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
    public partial class FrmReportesPXC : Form
    {
        private PrestamoNegocio _prestamoNegocio;
        private LibroNegocio _libroNegocio;
        private ClienteNegocio _clienteNegocio;
        private EjemplarNegocio _ejemplarNegocio;

        public FrmReportesPXC()
        {
            InitializeComponent();

            _prestamoNegocio = new PrestamoNegocio();
            _libroNegocio = new LibroNegocio();
            _clienteNegocio = new ClienteNegocio();
            _ejemplarNegocio = new EjemplarNegocio();

        }

        private void _btnPxC_Click(object sender, EventArgs e)
        {
            int idCliente = 0;
            List<Libro> listadoLibros = _libroNegocio.GetLista(); ;
            List <Cliente> listadoClientes = _clienteNegocio.GetLista();
            List<Ejemplar> listadoEjemplares = _ejemplarNegocio.GetLista();
            for (var i=0; i<listadoClientes.Count; i++)
            {
                if(listadoClientes[i].Id == int.Parse(_inputReporteCliente.Text))
                {
                    idCliente = i;
                }
            }
            _lblNombreCliente.Text = listadoClientes[idCliente].Apellido + ", " + listadoClientes[idCliente].Nombre;

            List<Prestamo> listadoPrestamo = _prestamoNegocio.GetLista();

            _dataGridReportePrestamos.Rows.Clear();
            foreach (Prestamo p in listadoPrestamo)
            {
                if (p.IdCliente == listadoClientes[idCliente].Id)
                {

                    for (var i = 0; i < listadoEjemplares.Count; i++)
                    {
                        if (listadoEjemplares[i].Id == p.IdEjemplar)
                        {
                            for (var j = 0; j < listadoLibros.Count; j++)
                            {
                                if (listadoLibros[j].Id == listadoEjemplares[i].IdLibro)
                                {
                                    int n = _dataGridReportePrestamos.Rows.Add();
                                    _dataGridReportePrestamos.Rows[n].Cells[0].Value = p.Id;
                                    _dataGridReportePrestamos.Rows[n].Cells[1].Value = listadoLibros[j].Titulo;
                                    _dataGridReportePrestamos.Rows[n].Cells[2].Value = listadoLibros[j].Autor;
                                    _dataGridReportePrestamos.Rows[n].Cells[3].Value = p.IdEjemplar;
                                    _dataGridReportePrestamos.Rows[n].Cells[4].Value = p.FechaAlta;
                                    _dataGridReportePrestamos.Rows[n].Cells[5].Value = p.FechaBaja;
                                }
                            }    
                        }
                    }                    
                }              

            }
        }

        private void _btnVolver5_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmBiblioteca frm1 = new FrmBiblioteca();

            frm1.Show();
        }
    }
}
