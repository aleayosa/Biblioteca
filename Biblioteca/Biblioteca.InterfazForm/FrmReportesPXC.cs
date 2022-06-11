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

        public FrmReportesPXC()
        {
            InitializeComponent();

            _prestamoNegocio = new PrestamoNegocio();
            _libroNegocio = new LibroNegocio();
            _clienteNegocio = new ClienteNegocio();

        }

        private void _btnPxC_Click(object sender, EventArgs e)
        {
            List<Cliente> listadoClientes = _clienteNegocio.GetLista();
            for(var i=0; i<listadoClientes.Count; i++)
            {
                if(listadoClientes[i].Id == int.Parse(_inputReporteCliente.Text))
                {
                    _lblNombreCliente.Text = listadoClientes[i].Apellido + ", " + listadoClientes[i].Nombre;
                }
            }
            List<Prestamo> listadoPrestamo = _prestamoNegocio.GetLista();

            _dataGridReportePrestamos.Rows.Clear();
            foreach (Prestamo p in listadoPrestamo)
            {
                if( p.IdCliente == int.Parse(_inputReporteCliente.Text))
                {
                    int n = _dataGridReportePrestamos.Rows.Add();
                    _dataGridReportePrestamos.Rows[n].Cells[0].Value = p.FechaAlta;
                    _dataGridReportePrestamos.Rows[n].Cells[1].Value = p.FechaBaja;
                    _dataGridReportePrestamos.Rows[n].Cells[2].Value = p.IdEjemplar;
                    _dataGridReportePrestamos.Rows[n].Cells[3].Value = p.IdCliente;
                    _dataGridReportePrestamos.Rows[n].Cells[4].Value = p.Plazo;
                }              

            }
        }

        private void _btnVolver5_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmBiblioteca frm1 = new FrmBiblioteca();

            frm1.Show();
        }

        private void _inputReporteCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
