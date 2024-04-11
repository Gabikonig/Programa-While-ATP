using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int estudo,cont5000, cont15a,contgeral;
            float salario, maiorsal, mediasal, mediaanos,psal5000, pestudo15, somaanos, somasal;
            char continua;
            maiorsal = somaanos = somasal = 0f; 
            cont5000 = cont15a = contgeral= 0;
            do
            {
                Console.WriteLine("Informe qual é o seu salário");
                salario = float.Parse(Console.ReadLine());
                somasal = somasal + salario;
                if (salario > maiorsal)
                {
                    maiorsal = salario;
                }
                if (salario <= 5000)
                {
                    cont5000++;
                }
                Console.WriteLine("Informe quantos anos de estudo você tem");
                estudo = int.Parse(Console.ReadLine());
                somaanos = somaanos + estudo;
                if (estudo >= 15)
                {
                    cont15a++;
                }
                contgeral++;
                Console.WriteLine("Deseja informar dados de outros habitante?\n Digite:\n S para sim\n N para não");
                continua= char.Parse(Console.ReadLine());
            } while (continua=='s' || continua=='S');
            mediasal = somasal / contgeral;
            Console.WriteLine("A média do salário da população é: R$" + mediasal);
            mediaanos = somaanos / contgeral;
            Console.WriteLine("A média de anos de estudo da população é: " + mediaanos + " anos");
            Console.WriteLine("O maior salário é: R$" + maiorsal);
            psal5000 = cont5000 * 100 / contgeral;
            Console.WriteLine("O percentual da população que tem o salário até R$5000 é: " + psal5000 + "%");
            pestudo15=cont15a*100 / contgeral;
            Console.WriteLine("O percentual da população que com 15 anos ou mais de estudo é: " + pestudo15 + "%");
            Console.ReadLine();
        }
    }
}
