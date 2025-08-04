using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza a adição de dois números e exibe o resultado.
        /// </summary>
        /// <param name="x">O primeiro número inteiro para somar</param>
        /// <param name="y">O segundo número inteiro para somar</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

         /// <summary>
        /// Realiza a adição de dois números e exibe o resultado.
        /// </summary>
        /// <param name="x">O primeiro número inteiro para somar</param>
        /// <param name="y">O segundo número inteiro para somar</param>
        /// <returns>Retorna a subração de x e y</returns>

        public int Subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
            return x - y;
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

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 2)}");
        }
        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno, 2)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 2)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }

        // Removido método duplicado Somar(int v1, int v2)
    }
}