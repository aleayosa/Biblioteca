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
        public FrmEjemplares()
        {
            InitializeComponent();
            _ejemplarNegocio = new EjemplarNegocio();
            _libroNegocio = new LibroNegocio();
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
                foreach (Ejemplar  e in listado)
                {
                    int n = _dataGridEjemplares.Rows.Add();
                    
                    foreach (Libro a in lib)
                        if (e.IdLibro == a.Id){
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
                if (Validar())
                {
                    AltaEjemplar(int.Parse(_inputIdLibro.Text), _inputObservaciones.Text, int.Parse(_inputPrecio.Text));
                    MessageBox.Show("Se ha generado el nuevo ejemplar");
                    Limpiar();
                    MostrarEjemplares();
                }
                else
                {
                    MessageBox.Show("Hay campos incompletos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar alta el ejemplar " + ex.Message);
            }
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(_inputIdLibro.Text))
                return false;
            if (string.IsNullOrEmpty(_inputObservaciones.Text))
                return false;
            if (string.IsNullOrEmpty(_inputPrecio.Text))
                return false;
   
            return true;
        }

        private void Limpiar()
        {
            _inputIdLibro.Text = string.Empty;
            _inputObservaciones.Text = string.Empty;
            _inputPrecio.Text = string.Empty;
            
        }

        private void FrmEjemplares_Load(object sender, EventArgs e)
        {
            MostrarEjemplares();
        }

        private void _btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmBiblioteca frm3 = new FrmBiblioteca();

            frm3.Show();
        }

        private void _dataGridEjemplares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _inputPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void _inputIdLibro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
