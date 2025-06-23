using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploFundamentos.Models
{
    public class Calculadora
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void divide(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
    }
}