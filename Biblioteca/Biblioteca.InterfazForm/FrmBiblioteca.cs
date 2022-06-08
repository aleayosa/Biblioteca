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
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void _btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmClientes frm = new FrmClientes();

            frm.Show();
        }

        private void _btnLibros_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmLibros frm1 = new FrmLibros();

            frm1.Show();
        }

        private void _btnPrestamos_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmPrestamos frm2 = new FrmPrestamos();

            frm2.Show();
        }

        private void _btnEjemplares_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmEjemplares frm3 = new FrmEjemplares();

            frm3.Show();
        }
    }
}
