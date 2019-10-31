using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuerdos.Utilidades
{
    public class Validaciones
    {
        
        public  void validarNumero(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)&&!char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        public void validarLetra(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        public void validarLetrasNumerosEspacio(object sender, KeyPressEventArgs e)
        {
            //IsLetter(e.KeyChar) permite cualquier caracter entre la a y la z tanto mayusculas como minusculas
            //'\b' permite poder eliminar caracteres con BackSpace

            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        public void validarLetrasNumeros(object sender, KeyPressEventArgs e)
        {
            //IsLetter(e.KeyChar) permite cualquier caracter entre la a y la z tanto mayusculas como minusculas
            //IsWhiteSpace permite espacio en blanco.
            //'\b' permite poder eliminar caracteres con BackSpace

            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        public Boolean formato_Numero(String dato)
        {
            string regex = @"^\d+$";
            // Validación
            if (Regex.IsMatch(dato, regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Valida que tenga formato de PIN osea 4 numeros
        public Boolean formato_PIN(String dato)
        {
            string regex = @"^\d{4}$";
            // Validación
            if (Regex.IsMatch(dato, regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Valida que el dato tenga el formato de correo.
        public Boolean formato_Correo(String dato)
        {
            string regex = @"^((([\w]+\.[\w]+)+)|([\w]+))@(([\w]+\.)+)([A-Za-z]{1,3})$";
            // Validación
            if (Regex.IsMatch(dato, regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Valida el formato de una contraceña con un rango de caracteres
        public Boolean formato_Contracena(String dato)
        {
            string regex = @"^\w{6,8}$";
            // Validación
            if (Regex.IsMatch(dato, regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Valida el formato de una contraceña con un rango de caracteres
        public Boolean formato_usuario(String dato)
        {
            string regex = @"/^[a-z0-9_-]{3,10}$/";
            // Validación
            if (Regex.IsMatch(dato, regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Valida el formato de un numero de telefono
        public Boolean validar_Celular(String dato)
        {
            if (formato_Numero(dato) && dato.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Valida formato alfanumerico con espacios en un string yno  permite string en blanco
        public Boolean formato_Cadena_Alfanumerica(String dato)
        {
            //string regex = @"[^a-zA-Z0-9]";
            string regex = "/[A-Z0-9._%+-]+@[A-Z0-9-]+.+.[A-Z]{2,4}/igm";
            // Validación
            if (Regex.IsMatch(dato, regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Valida ingreso sea alfabetico y permite espacios
        public Boolean formato_Alfabetico_Espacios(String dato)
        {
            string regex = @"[A-Za-z]$";
            // Validación
            if (Regex.IsMatch(dato, regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Valida formato alfanumerico en un palabra y no permite espacios en blanco
        public Boolean formato_Palabra_Alfanumerica(String dato)
        {
            string regex = @"^[a-zA-Z0-9]+$";
            // Validación
            if (Regex.IsMatch(dato, regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
