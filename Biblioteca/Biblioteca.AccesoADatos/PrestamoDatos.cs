using Biblioteca.Entidades;
using Biblioteca.AccesoADatos.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace Biblioteca.AccesoADatos
{
    public class PrestamoDatos
    {
        public List<Prestamo> TraerTodos()
        {
            string json2 = WebHelper.Get("biblioteca/prestamos"); // trae un texto en formato json de una web
            List<Prestamo> resultado = MapList(json2);
            return resultado;
        }

        private List<Prestamo> MapList(string json)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json); // deserializacion
            return lst;
        }

        public TransactionResult Insertar(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo); //serializacion -> json

            string json = WebHelper.Post("biblioteca/prestamos", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);

            string json = WebHelper.Put("biblioteca/prestamos", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Eliminar(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);

            string json = WebHelper.Delete("biblioteca/prestamos", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", prestamo.Id.ToString());
            n.Add("idCliente", prestamo.IdCliente.ToString());
            n.Add("idEjemplar", prestamo.IdEjemplar.ToString());
            n.Add("Plazo", prestamo.Plazo.ToString());
            n.Add("FechaPrestamo", prestamo.FechaPrestamo.ToString("yyyy-MM-dd"));
            n.Add("FechaDevolucionReal", prestamo.FechaDevolucionReal.ToString("yyyy-MM-dd"));
            n.Add("FechaDevolucionTentativa", prestamo.FechaDevolucionTentativa.ToString("yyyy-MM-dd"));
            return n;
        }
    }
}
