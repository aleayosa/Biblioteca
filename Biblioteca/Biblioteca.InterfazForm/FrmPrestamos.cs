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
        public FrmPrestamos()
        {
            InitializeComponent();

            _prestamoNegocio = new PrestamoNegocio();
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

                List<Prestamo> listado = _prestamoNegocio.GetLista();
                _dataGridPrestamos.Rows.Clear();
                foreach (Prestamo p in listado)
                {
                    int n = _dataGridPrestamos.Rows.Add();
                    _dataGridPrestamos.Rows[n].Cells[0].Value = p.IdCliente;
                    _dataGridPrestamos.Rows[n].Cells[1].Value = p.IdEjemplar;
                    _dataGridPrestamos.Rows[n].Cells[2].Value = p.FechaAlta;
                    _dataGridPrestamos.Rows[n].Cells[3].Value = p.FechaBaja;
                    _dataGridPrestamos.Rows[n].Cells[4].Value = p.FechaBajaReal;
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
    }
}
