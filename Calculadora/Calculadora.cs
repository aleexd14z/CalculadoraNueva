using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public int Sumar(string numeros)
        {
            if (string.IsNullOrEmpty(numeros)) return 0;
            if (string.IsNullOrEmpty(numeros)) return 0;

            string[] numerosSeparados = numeros.Split(',');
            int suma = 0;
            foreach (string numero in numerosSeparados)
            {
                suma += int.Parse(numero);
            }
            return suma;
        }
    }
}
