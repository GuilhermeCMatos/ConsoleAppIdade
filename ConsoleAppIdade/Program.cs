using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a sua idade em ano: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("digite sua idade em meses: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("digite sua idade em dias: ");
            int d = int.Parse(Console.ReadLine());

            int resultado = (a * 365) + (m * 30) + d;

            Console.WriteLine("Você tem " + resultado + " dias de vida");

            Console.ReadKey();
        }
    }
}
