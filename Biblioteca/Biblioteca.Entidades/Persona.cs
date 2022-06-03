using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Persona
    {
        private int _id;
        protected string _nombre;
        private string _apellido;
        private string _direccion;
        private string _email;
        private string _telefono;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

    }
}
