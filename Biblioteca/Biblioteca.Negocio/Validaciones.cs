using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class Validaciones
    {
        public int ValidarInt(string dato, string campo, int min, int max)
        {
            int opcion = 0;
            if (!ValidarNull(dato))
                throw new Exception("El campo " + campo +" no puede estar vacío");
            if (!int.TryParse(dato, out opcion))
            {
                throw new Exception("El campo " + campo + " ingresado no es válido.");
            }
            else
            {
                if (int.Parse(dato) < 1)
                {
                    throw new Exception("El campo " + campo + " ingresado no es válido.");
                }
                else if (int.Parse(dato) < min || int.Parse(dato) > max)
                {
                    throw new Exception("El campo " + campo + " ingresado no es válido.\nDebe ingresar un número entre " + min + " y " + max);
                }
                else
                {
                    return opcion;
                }
            }
        }

        public string ValidarString(string dato, string label)
        {
            if (!ValidarNull(dato))
                throw new Exception("El campo " + label + " no puede estar vacío");
            else if (int.TryParse(dato, out int opcionValidar))
                throw new Exception("El valor ingresado en " + label + " no posee el formato adecuado. Ingreselo nuevamente");
            else
                return dato;
        }

        public bool ValidarNull(string dato)
        {
            if (string.IsNullOrEmpty(dato))
                return false;
            return true;
        }

        public long ValidarLong(string dato, string campo, int min, long max)
        {
            long opcion = 0;
            if (!ValidarNull(dato))
                throw new Exception("El campo " + campo + " no puede estar vacío");
            if (!long.TryParse(dato, out opcion))
            { 
                throw new Exception("El campo " + campo + " ingresado no es válido.");
            }
            else
            {
                if (long.Parse(dato) < 1)
                {
                    throw new Exception("El campo " + campo + " ingresado no es válido.");
                }
                else if (long.Parse(dato) < min || long.Parse(dato) > max)
                {
                    throw new Exception("El campo " + campo + " ingresado no es válido.\nDebe ingresar un número entre " + min + " y " + max);
                }
                else
                {
                    return opcion;
                }
            }
        }
        public double ValidarDouble(string dato, string campo, int min, double max)
        {
            double opcion = 0;
            if (!ValidarNull(dato))
                throw new Exception("El campo " + campo + " no puede estar vacío");
            if (!double.TryParse(dato, out opcion))
            {
                throw new Exception("El campo " + campo + " ingresado no es válido.");
            }
            else
            {
                if (double.Parse(dato) < 1)
                {
                    throw new Exception("El campo " + campo + " ingresado no es válido.");
                }
                else if (double.Parse(dato) < min || double.Parse(dato) > max)
                {
                    throw new Exception("El campo " + campo + " ingresado no es válido.\nDebe ingresar un número entre " + min + " y " + max);
                }
                else
                {
                    return opcion;
                }
            }
        }
    }
}