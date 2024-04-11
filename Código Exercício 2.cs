using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont, dia;
            float indice, soma, media, imax;
            cont = 1;
            imax = 0;
            soma = 0;
            dia = 0;
            while (cont <= 31)
            {
                Console.WriteLine("Informe o índice pluviométrico");
                indice = float.Parse(Console.ReadLine());
                if (indice > imax)
                {
                    imax = indice;
                    dia = cont;
                }
                soma = soma + indice;
                cont++;
            }
            media = soma / 31;
            Console.WriteLine("O índice pluviométrico médio é: " + media);
            Console.WriteLine("O dia de maior índice pluviométrico foi: " + dia + "E o índice pluviométrico desse dia foi: " + imax);
            Console.ReadLine();
        }
    }
}
