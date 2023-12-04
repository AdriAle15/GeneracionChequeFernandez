using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public static class NumLetras
    {

        private static string[] unidades = {"","uno","dos","tres","cuatro", "cinco", "seis", "siete",
        "ocho", "nueve", "diez","once","doce","trece","catorce", "quince", "dieciseis", "diecisiete",
        "dieciocho", "diecinueve" };

        private static string[] decenas = {"","diez","veinte","treinta","cuarenta", "cincuenta",
        "sesenta", "setenta", "ochenta", "noventa"};

        private static string[] nombres_100_900 = {"","ciento","doscientos","trescientos","cuatrocientos",
        "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"};

        public static string obtener_nombre_unidades(int num)
        {
            return unidades[num];
        }

        public static string obtener_nombre_decenas(int num)
        {
            string nombre = decenas[num / 10];
            int unidad = num % 10;
            if (unidad > 0)
            {
                string nombre_unidad = obtener_nombre_unidades(unidad);
                string buffer = nombre == "" ? string.Format("{0}", nombre_unidad) : string.Format("{0} y {1}"
                , nombre, nombre_unidad);
                nombre = string.Copy(buffer);
            }
            return nombre;
        }

        public static string obtener_nombre_centenas(int num)
        {
            string nombre = nombres_100_900[num / 100];
            int resto = num % 100;
            if (resto > 0)
            {
                string nombre_resto = obtener_nombre_decenas(resto);
                string buffer = string.Format("{0} {1}", nombre, nombre_resto);
                nombre = string.Copy(buffer);
            }

            return nombre;
        }

        public static string obtenerNombre(int num)
        {
            if (num < 0)
            {
                return ("Cantidad no válida");
            }
            else if (num < 20)
            {
                return obtener_nombre_unidades(num);
            }
            else if (num < 100)
            {
                return obtener_nombre_decenas(num);
            }
            else
            {
                return ("Cantidad fuera de rango");
            }
        }
    }
}
