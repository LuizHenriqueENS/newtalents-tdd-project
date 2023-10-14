using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents.Console.Services
{
    public class Calculadora
    {
        private List<string> _historico = new List<string>();

        public int Somar(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            _historico.Insert(0, $"{valor1} + {valor2} = {resultado}");
            return valor1 + valor2;
        }

        public int Subtrair(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;
            _historico.Insert(0, $"{valor1} - {valor2} = {resultado}");
            return valor1 - valor2;
        }
        public int Multiplicar(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;
            _historico.Insert(0, $"{valor1} * {valor2} = {resultado}");
            return valor1 * valor2;
        }
        public int Dividir(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;
            _historico.Insert(0, $"{valor1} / {valor2} = {resultado}");
            return valor1 / valor2;
        }

        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }

    }
}