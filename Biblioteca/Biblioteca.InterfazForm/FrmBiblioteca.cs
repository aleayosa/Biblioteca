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

            FrmClientes frm = new FrmClientes(this);

            frm.Show();
        }

        private void _btnLibros_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmLibros frm1 = new FrmLibros(this);

            frm1.Show();
        }

        private void _btnPrestamos_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmPrestamos frm2 = new FrmPrestamos(this);

            frm2.Show();
        }

        private void _btnEjemplares_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmEjemplares frm3 = new FrmEjemplares(this);

            frm3.Show();
        }

        private void _btnReportesPrestamos_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmReportesPXC frm4 = new FrmReportesPXC(this);

            frm4.Show();
        }

        private void _btnReporteEjemplares_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmReportesEXL frm5 = new FrmReportesEXL(this);

            frm5.Show();
        }
    }
}
