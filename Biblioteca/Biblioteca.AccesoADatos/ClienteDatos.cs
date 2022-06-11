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
    public class ClienteDatos
    {
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("cliente"); // trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }

        public List<Cliente> Traer(int usuario)
        {
            string json2 = WebHelper.Get("cliente/" + usuario.ToString()); // trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }

        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json); // deserializacion
            return lst;
        }

        private Cliente MapObj(string json)
        {
            Cliente lst = JsonConvert.DeserializeObject<Cliente>(json); // deserializacion
            return lst;
        }

        public TransactionResult Insertar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente); //serializacion -> json

            string json = WebHelper.Post("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);

            string json = WebHelper.Put("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cliente.Id.ToString());
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Telefono", cliente.Telefono);
            n.Add("Email", cliente.Email);
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("FechaAlta", cliente.FechaAlta.ToString("yyyy-MM-dd"));
            n.Add("Usuario", "880828");
            return n;
        }
    }
}
