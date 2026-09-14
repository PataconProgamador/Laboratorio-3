using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab3_1
{
    internal class Utilidades
    {
        public static bool EsCorreoValido(string email)
        {
            // Llama al método auxiliar para verificar si está en blanco
            if (EstaEnBlanco(email))
            {
                return false;
            }

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron);
        }

        public static bool EstaEnBlanco(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }
    }
}
