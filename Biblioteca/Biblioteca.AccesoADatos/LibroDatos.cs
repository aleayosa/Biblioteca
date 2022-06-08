
using Biblioteca.AccesoADatos.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Biblioteca.Entidades;

namespace Biblioteca.AccesoADatos
{
    public class LibroDatos
    {
        public List<Libro> TraerTodos()
        {
            string json2 = WebHelper.Get("biblioteca/libros"); // trae un texto en formato json de una web
            List<Libro> resultado = MapList(json2);
            return resultado;
        }

        private List<Libro> MapList(string json)
        {
            List<Libro> lst = JsonConvert.DeserializeObject<List<Libro>>(json); // deserializacion
            return lst;
        }

        private Libro MapObj(string json)
        {
            Libro lst = JsonConvert.DeserializeObject<Libro>(json); // deserializacion
            return lst;
        }

        //public TransactionResult Insertar(Libro libros)
        //{
        //    NameValueCollection obj = ReverseMap(libros); //serializacion -> json

        //    string json = WebHelper.Post("biblioteca/libros", obj);

        //    TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

        //    return lst;
        //}

        //public TransactionResult Actualizar(Libro libros)
        //{
        //    NameValueCollection obj = ReverseMap(libros);

        //    string json = WebHelper.Put("biblioteca/libros", obj);

        //    TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

        //    return lst;
        //}
        //private NameValueCollection ReverseMap(Libro libro)
        //{
        //    NameValueCollection n = new NameValueCollection();
        //    n.Add("Edicion", libro.Edicion.ToString());
        //    n.Add("Paginas", libro.Paginas.ToString());
        //    n.Add("Titulo", libro.Titulo);
        //    n.Add("Autor", libro.Autor);
        //    n.Add("Editorial", libro.Editorial);
        //    n.Add("Tema", libro.Tema);
        //    n.Add("id", libro.Id.ToString());
        //    return n;
        //}
    }
}
