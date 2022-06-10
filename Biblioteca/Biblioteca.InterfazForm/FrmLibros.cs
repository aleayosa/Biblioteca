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
    public partial class FrmLibros : Form
    {
        private LibroNegocio _libroNegocio;
        public FrmLibros()
        {
            InitializeComponent();
            _libroNegocio = new LibroNegocio();
        }

        private void AltaLibro(string titulo, string autor, int edicion, string editorial, int paginas, string tema)
        {
            _libroNegocio.Alta(titulo, autor, edicion, editorial, paginas, tema);

        }

        private void MostrarLibros()
        {
            try
            {
                string libros = string.Empty;

                List<Libro> listado = _libroNegocio.GetLista();

                _dataGridLibros.Rows.Clear();
                foreach (Libro l in listado)
                {
                    int n = _dataGridLibros.Rows.Add();
                    _dataGridLibros.Rows[n].Cells[0].Value = l.Titulo;
                    _dataGridLibros.Rows[n].Cells[1].Value = l.Autor;
                    _dataGridLibros.Rows[n].Cells[2].Value = l.Edicion;
                    _dataGridLibros.Rows[n].Cells[3].Value = l.Editorial;
                    _dataGridLibros.Rows[n].Cells[4].Value = l.Paginas;
                    _dataGridLibros.Rows[n].Cells[5].Value = l.Tema;
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar los libros: " + ex.Message);
            }

        }
        private void _btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    AltaLibro(_inputTitulo.Text, _inputAutor.Text, int.Parse(_inputEdicion.Text), _inputEditorial.Text, int.Parse(_inputPaginas.Text), _inputTemas.Text);
                    MessageBox.Show("Se ha generado el nuevo libro");
                    Limpiar();
                    MostrarLibros();
                }
                else
                {
                    MessageBox.Show("Hay campos incompletos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar alta el libro " + ex.Message);
            }
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(_inputTitulo.Text))
                return false;
            if (string.IsNullOrEmpty(_inputAutor.Text))
                return false;
            if (string.IsNullOrEmpty(_inputEdicion.Text))
                return false;
            if (string.IsNullOrEmpty(_inputEditorial.Text))
                return false;
            if (string.IsNullOrEmpty(_inputPaginas.Text))
                return false;
            if (string.IsNullOrEmpty(_inputTemas.Text))
                return false;

            return true;
        }

        private void Limpiar()
        {
            _inputTitulo.Text = string.Empty;
            _inputAutor.Text = string.Empty;
            _inputEditorial.Text = string.Empty;
            _inputEdicion.Text = string.Empty;
            _inputPaginas.Text = string.Empty;
            _inputTemas.Text = string.Empty;
        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            MostrarLibros();
        }

        private void _btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmBiblioteca frm3 = new FrmBiblioteca();

            frm3.Show();
        }

        private void _inputDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void _inputTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
