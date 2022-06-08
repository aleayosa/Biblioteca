using Biblioteca.AccesoADatos;
using Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class PrestamoNegocio
    {
        private PrestamoDatos _prestamoDatos;

        public PrestamoNegocio()
        {
            _prestamoDatos = new PrestamoDatos();
        }

        public List<Prestamo> GetLista()
        {
            List<Prestamo> list = _prestamoDatos.TraerTodos();

            return list;
        }

        public void Alta(int idCliente, int idEjemplar, int plazo)
        {
            Prestamo prestamo = new Prestamo();
            prestamo.IdCliente = idCliente;
            prestamo.IdEjemplar = idEjemplar;
            prestamo.Plazo = plazo;
            prestamo.FechaAlta = DateTime.Now;
            prestamo.FechaBaja = DateTime.Now.AddDays(plazo);
            TransactionResult transaction = _prestamoDatos.Insertar(prestamo);

            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }
    }
}
