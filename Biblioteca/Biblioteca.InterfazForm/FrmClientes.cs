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
    public partial class FrmClientes : Form
    {
        private ClienteNegocio _clienteNegocio;
        public FrmClientes()
        {
            InitializeComponent();

            _clienteNegocio = new ClienteNegocio();
        }

        private void AltaCliente(string nombre, string apellido, string direccion, string telefono, string email)
        {
            _clienteNegocio.Alta(nombre, apellido, direccion, telefono, email);

        }

        private void MostrarCliente()
        {
            try
            {
                string clientes = string.Empty;

                List<Cliente> listado = _clienteNegocio.GetLista();
                _dataGridClientes.Rows.Clear();
                foreach (Cliente c in listado)
                {                    
                        int n = _dataGridClientes.Rows.Add();
                        _dataGridClientes.Rows[n].Cells[0].Value = c.Nombre;
                        _dataGridClientes.Rows[n].Cells[1].Value = c.Apellido;
                        _dataGridClientes.Rows[n].Cells[2].Value = c.Direccion;
                        _dataGridClientes.Rows[n].Cells[3].Value = c.Telefono;
                        _dataGridClientes.Rows[n].Cells[4].Value = c.Email;                   
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar los clientes: " + ex.Message);
            }

        }

        private void _btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    AltaCliente(_inputNombre.Text, _inputApellido.Text, _inputDireccion.Text, _inputTelefono.Text, _inputEmail.Text);
                    MessageBox.Show("Se ha generado el nuevo cliente");
                    Limpiar();
                    MostrarCliente();
                }
                else
                {
                    MessageBox.Show("Hay campos incompletos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar alta al cliente " + ex.Message);
            }                         

        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(_inputNombre.Text))
                return false;
            if (string.IsNullOrEmpty(_inputApellido.Text))
                return false;
            if (string.IsNullOrEmpty(_inputDireccion.Text))
                return false;
            if (string.IsNullOrEmpty(_inputEmail.Text))
                return false;
            if (string.IsNullOrEmpty(_inputTelefono.Text))
                return false;

            return true;
        }

        private void _btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarCliente();
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            MostrarCliente();
        }

        private void Limpiar()
        {
            _inputNombre.Text = string.Empty;
            _inputApellido.Text = string.Empty;
            _inputDireccion.Text = string.Empty;
            _inputTelefono.Text = string.Empty;
            _inputEmail.Text = string.Empty;
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmBiblioteca frm2 = new FrmBiblioteca();

            frm2.Show();
        }

    }
}
