using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, idade, conttot, contf1, contf2, contf3, contf4, contf5;
            float porcen1, porcen2, porcen3, porcen4, porcen5;
            conttot = 1;
            contf1 = contf2 = contf3 = contf4 = contf5 = 0;
            Console.WriteLine("Informe o número de idades");
            n=int.Parse(Console.ReadLine());
            while (conttot <= n)
            {
                Console.WriteLine("Informe a idade");
                idade= int.Parse(Console.ReadLine());
                if (idade >= 1 && idade <= 15)
                {
                    contf1++;
                }
                else if (idade >= 16 && idade <= 30)
                {
                    contf2++;
                }
                else if(idade >= 31 && idade <= 45)
                {
                    contf3++;
                }
                else if (idade >=46 && idade <= 60)
                {
                    contf4++;
                }
                else if (idade >= 61)
                {
                    contf5++;
                }
                conttot++;
            }
            porcen1 = (100 * contf1) / n;
            porcen2= (100 * contf2) / n;
            porcen3= (100 * contf3) / n;
            porcen4=(100 * contf4) / n;
            porcen5=(100 * contf5) / n;
            Console.WriteLine("1 a 15 anos: " + contf1 + " pessoas - " + porcen1 + "% do total de pessoas");
            Console.WriteLine("16 a 30 anos: " + contf2 + " pessoas - " + porcen2 + "% do total de pessoas");
            Console.WriteLine("31 a 45 anos: " + contf3 + " pessoas - " + porcen3 + "% do total de pessoas");
            Console.WriteLine("46 a 60 anos: " + contf4 + " pessoas - " + porcen4 + "% do total de pessoas");
            Console.WriteLine("61 anos ou mais: " + contf5 + " pessoas - " + porcen5 + "% do total de pessoas");
            Console.ReadLine();
        }
        
    }
}
