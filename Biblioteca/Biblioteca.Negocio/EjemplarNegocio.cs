using Biblioteca.AccesoADatos;
using Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class EjemplarNegocio
    {
        private EjemplarDatos _ejemplarDatos;

        public EjemplarNegocio()
        {
            _ejemplarDatos = new EjemplarDatos();
        }

        public List<Ejemplar> GetLista()
        {
            List<Ejemplar> list = _ejemplarDatos.TraerTodos();

            return list;
        }

        public void Alta(int libro, string observacion, int precio)
        {
            Ejemplar ejemplar = new Ejemplar();
            ejemplar.IdLibro = libro;
            ejemplar.FechaAlta = DateTime.Now.AddDays(-6000);
            ejemplar.Activo = true;
            ejemplar.Precio = precio;
            ejemplar.Observaciones = observacion;
            TransactionResult transaction = _ejemplarDatos.Insertar(ejemplar);

            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }
    }
}
