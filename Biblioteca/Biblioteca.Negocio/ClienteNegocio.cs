using Biblioteca.AccesoADatos;
using Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class ClienteNegocio
    {
        private ClienteDatos _clienteDatos;

        public ClienteNegocio()
        {
            _clienteDatos = new ClienteDatos();
        }

        public List<Cliente> GetLista()
        {
            List<Cliente> list = _clienteDatos.Traer(880828);

            return list;
        }

        public Cliente GetPorTelefono(string telefono)
        {
            Cliente cli = _clienteDatos.TraerPorTelefono(telefono);

            return cli;
        }

        public void Alta(string nombre, string apellido, string direccion, string telefono, string email)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Direccion = direccion;
            cliente.Telefono = telefono;
            cliente.Email = email;
            cliente.FechaAlta = DateTime.Now.AddDays(-6000);
            TransactionResult transaction = _clienteDatos.Insertar(cliente);

            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }
    }
}
