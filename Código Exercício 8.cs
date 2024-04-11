using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,n1, elemento,nanterior, natual, nfibonacci;
            nanterior=elemento= 0;
            natual = nfibonacci= 1;
            Console.WriteLine("Informe um número");
            n = int.Parse(Console.ReadLine());
           
            while (n < 0)
            {
                Console.WriteLine("Número inválido\n Informe outro número");
                n=int.Parse(Console.ReadLine());
            }
            Console.Write("Sequência de Fibonacci: " + nfibonacci);
                   
            do
            {
                nfibonacci = nanterior + natual;
                Console.Write(" " + nfibonacci);
                n1=n-natual;
                nanterior = natual;
                natual = nfibonacci;
                
            } while (nfibonacci<n1);
             Console.ReadLine();
        }
    }
}
