using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, elemento, nanterior, natual, nfibonacci;
            nanterior= 0;
            elemento=natual = nfibonacci = 1;
            Console.WriteLine("Informe quantos elementos da sequência de Fibonacci você deseja");
            n=int.Parse(Console.ReadLine());
            while (n<0)
            { 
                Console.WriteLine("Número inválido\n Informe quantos elementos da sequência de Fibonacci você deseja");
                n = int.Parse(Console.ReadLine());
            }
            Console.Write("Sequência de Fibonacci: " + nfibonacci);     
            while (elemento<n)
            {
                nfibonacci = nanterior + natual;
                Console.Write(" "+nfibonacci);
                nanterior = natual;
                natual = nfibonacci;
                elemento++;
            }
            Console.ReadLine();
        }
    }
}
