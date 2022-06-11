using Biblioteca.AccesoADatos;
using Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class LibroNegocio
    {
        private LibroDatos _libroDatos;

        public LibroNegocio()
        {
            _libroDatos = new LibroDatos();
        }

        public List<Libro> GetLista()
        {
            List<Libro> list = _libroDatos.TraerTodos();

            return list;
        }

        public void Alta(string titulo, string autor, int edicion, string editorial, int paginas, string temas)
        {
            Libro libro = new Libro();
            libro.Titulo = titulo;
            libro.Autor = autor;
            libro.Edicion = edicion;
            libro.Editorial = editorial;
            libro.Paginas = paginas;
            libro.Tema = temas;
            TransactionResult transaction = _libroDatos.Insertar(libro);

            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }

        public void Modificar(string titulo, string autor, int edicion, string editorial, int paginas, string temas)
        {
            Libro libro = new Libro();
            libro.Titulo = titulo;
            libro.Autor = autor;
            libro.Edicion = edicion;
            libro.Editorial = editorial;
            libro.Paginas = paginas;
            libro.Tema = temas;
            TransactionResult transaction = _libroDatos.Actualizar(libro);

            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }

    }
}
