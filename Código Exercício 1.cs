using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios_3___ATP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, num1, num2;
            Console.WriteLine("Informe o primeiro número (ímpar)");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o segundo número (ímpar)");
            y = int.Parse(Console.ReadLine());
            num1 = x % 2;
            num2 = y % 2;
            if (num1 == 0 || num2 == 0 || x > y)
            {
                Console.WriteLine("Erro! Valor inválido");
            }
            else if (num1 != 0 && num2 != 0)
            {
                Console.WriteLine("os números ímpares entre os dois números são: ");
                while (x <= y)
                {
                    num1 = x % 2;
                    num2 = y % 2;
                    if (num1 != 0 && num2 != 0)
                    {
                        Console.Write(x + " ");
                    }
                    x++;
                }
            }
            Console.ReadLine();
        }
    }
}
