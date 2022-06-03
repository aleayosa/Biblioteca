using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Prestamo
    {
        private int _id;
        private int _idCliente;
        private int _idEjemplar;
        private int _plazo;
        private DateTime _fechaAlta;
        private DateTime _fechaBaja;
        private DateTime _fechaBajaReal;

        public int Id { get => _id; set => _id = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdEjemplar { get => _idEjemplar; set => _idEjemplar = value; }
        public int Plazo { get => _plazo; set => _plazo = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        public DateTime FechaBajaReal { get => _fechaBajaReal; set => _fechaBajaReal = value; }


    }
}
