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
    public class EjemplarDatos
    {
        public List<Ejemplar> TraerTodos()
        {
            string json2 = WebHelper.Get("biblioteca/ejemplares"); // trae un texto en formato json de una web
            List<Ejemplar> resultado = MapList(json2);
            return resultado;
        }

        public List<Ejemplar> Traer(int idLibro)
        {
            string json2 = WebHelper.Get("biblioteca/ejemplares/" + idLibro.ToString()); // trae un texto en formato json de una web
            List<Ejemplar> resultado = MapList(json2);
            return resultado;
        }
        
        private List<Ejemplar> MapList(string json)
        {
            List<Ejemplar> lst = JsonConvert.DeserializeObject<List<Ejemplar>>(json); // deserializacion
            return lst;
        }

        private Ejemplar MapObj(string json)
        {
            Ejemplar lst = JsonConvert.DeserializeObject<Ejemplar>(json); // deserializacion
            return lst;
        }

        public TransactionResult Insertar(Ejemplar ejemplar)
        {
            NameValueCollection obj = ReverseMap(ejemplar); //serializacion -> json

            string json = WebHelper.Post("biblioteca/ejemplares", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Ejemplar ejemplar)
        {
            NameValueCollection obj = ReverseMap(ejemplar);

            string json = WebHelper.Put("biblioteca/ejemplares", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Ejemplar ejemplar)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", ejemplar.Id.ToString());
            n.Add("idLibro", ejemplar.IdLibro.ToString());
            n.Add("Observaciones", ejemplar.Observaciones);
            n.Add("Precio", ejemplar.Precio.ToString());
            n.Add("FechaAlta", ejemplar.FechaAlta.ToString("yyyy-MM-dd"));
            return n;
        }
    }
}
