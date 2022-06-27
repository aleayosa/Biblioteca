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
        private Validaciones _validaciones;
        public FrmLibros(Form padre)
        {
            InitializeComponent();
            _libroNegocio = new LibroNegocio();
            _validaciones = new Validaciones();
            this.Owner = padre;
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
                    _dataGridLibros.Rows[n].Cells[0].Value = l.Id;
                    _dataGridLibros.Rows[n].Cells[1].Value = l.Titulo;
                    _dataGridLibros.Rows[n].Cells[2].Value = l.Autor;
                    _dataGridLibros.Rows[n].Cells[3].Value = l.Edicion;
                    _dataGridLibros.Rows[n].Cells[4].Value = l.Editorial;
                    _dataGridLibros.Rows[n].Cells[5].Value = l.Paginas;
                    _dataGridLibros.Rows[n].Cells[6].Value = l.Tema;
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
                Validar();
                AltaLibro(_inputTitulo1.Text, _inputAutor1.Text, int.Parse(_inputEdicion1.Text), _inputEditorial1.Text, int.Parse(_inputPaginas1.Text), _inputTemas1.Text);
                MessageBox.Show("Se ha generado el nuevo libro");
                Limpiar();
                MostrarLibros();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar alta el libro: " + ex.Message);
            }
        }

        private void Validar()
        {
            _inputTitulo1.Text = _validaciones.ValidarString(_inputTitulo1.Text, _inputTitulo.Text);
            _inputAutor1.Text = _validaciones.ValidarString(_inputAutor1.Text, _inputAutor.Text); ;
            _inputEdicion1.Text= _validaciones.ValidarInt(_inputEdicion1.Text, _inputEdicion.Text, 1400, DateTime.Now.Year).ToString();
            _inputEditorial1.Text = _validaciones.ValidarString(_inputEditorial1.Text, _inputEditorial.Text);
            _inputPaginas1.Text = _validaciones.ValidarInt(_inputPaginas1.Text, _inputPaginas.Text, 1, 4000).ToString();
            _inputTemas1.Text = _validaciones.ValidarString(_inputTemas1.Text, _inputTemas.Text);

        }

        private void Limpiar()
        {
            _inputTitulo1.Text = string.Empty;
            _inputAutor1.Text = string.Empty;
            _inputEditorial1.Text = string.Empty;
            _inputEdicion1.Text = string.Empty;
            _inputPaginas1.Text = string.Empty;
            _inputTemas1.Text = string.Empty;
        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            MostrarLibros();
        }

        private void _btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

    }
}
