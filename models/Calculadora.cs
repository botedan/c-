using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_XP.models
{
    public class Calculadora
    {
           public void soma(int x, int y)
        {
            Console.WriteLine($"{x} + {y}= {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y}= {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} X {y}= {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y}= {x / y}");
        }
        
        public void potencia(int x, int y)
        {
            double Pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y}= {Pot}");
        }
       
       public void Seno(double angulo)
        {
            double radiano= angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno de {angulo}° = {Math.Round (seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano= angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O seno de {angulo}° = {Math.Round (coseno, 4) }");
        }
        public void Tangente(double angulo)
        {
            double radiano= angulo * Math.PI / 180;
            double Tangente = Math.Tan(radiano);
            Console.WriteLine($"O seno de {angulo}° = {Math.Round (Tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} = {raiz}");
        }
    }
}