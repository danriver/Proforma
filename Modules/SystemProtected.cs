using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proforma.Modules
{
    public static class SystemProtected
    {

        static string patron_busqueda = "aeAEbcdfghijklmnopqrstuvwxyz0123456789BCDFGHIJKLMNOPQRSTUVWXYZ";
        static string patron_encripta = "potre42ASD7531sdfghjklFGHwq086JKLMNBiuyVCXZQWERzxcvbnmaTYUIOP9";

        public static string EncriptarCadena(string cadena)
        {
            string result = "";
            for (int i = 0; i <= cadena.Length - 1; i++)
            {
                result += EncriptarCaracter(cadena.Substring(i, 1), cadena.Length, i);
            }
            return result;
        }

        public static string DesEncriptarCadena(string cadena)
        {
            string result = "";

            for (int idx = 0; idx <= cadena.Length - 1; idx++)
            {
                result += DesEncriptarCaracter(cadena.Substring(idx, 1), cadena.Length, idx);
            }
            return result;
        }

        private static string EncriptarCaracter(string caracter, int variable, int a_indice)
        {
            int indice = 0;
            if (patron_busqueda.IndexOf(caracter) != -1)
            {
                indice = (patron_busqueda.IndexOf(caracter) + variable + a_indice) % patron_busqueda.Length;
                return patron_encripta.Substring(indice, 1);
            }
            return caracter;
        }

        private static string DesEncriptarCaracter(string caracter, int variable, int a_indice)
        {
            int indice = 0;
            if (patron_encripta.IndexOf(caracter) != -1)
            {
                if ((patron_encripta.IndexOf(caracter) - variable - a_indice) > 0)
                {
                    indice = (patron_encripta.IndexOf(caracter) - variable - a_indice) % patron_encripta.Length;
                }
                else
                { 
                    indice = (patron_busqueda.Length) + ((patron_encripta.IndexOf(caracter) - variable - a_indice) % patron_encripta.Length);
                }
                indice = indice % patron_encripta.Length;
                return patron_busqueda.Substring(indice, 1);
            }
            return caracter;
        }
    }
}
