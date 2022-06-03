using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Ejemplar
    {
        private int _id;
        private int _idLibro;
        private bool _activo;
        private string _observaciones;
        private int _precio;
        private DateTime _fechaAlta;

        public int Id { get => _id; set => _id = value; }
        public int IdLibro { get => _idLibro; set => _idLibro = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public bool Activo { get => _activo; set => _activo = value; }
    }
}
