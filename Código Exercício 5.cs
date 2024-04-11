using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, tempo;
            float salario, novosal, ferias, sal13;
            Console.WriteLine("Escolha uma opção: \n 1.Novo salário\n 2. Férias\n 3. 13° salário\n 4. Sair");
            opcao=int.Parse(Console.ReadLine());
            while (opcao<=0 || opcao>4)
            {
                Console.WriteLine("Opção inválida\n Escolha a opção novamente");
                opcao = int.Parse(Console.ReadLine());
            }
            do
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe seu salário");
                        salario = float.Parse(Console.ReadLine());
                        while (salario < 0)
                        {
                            Console.WriteLine("Salário inválido\n Informe o salário novamente");
                            salario = float.Parse(Console.ReadLine());
                        }
                        if (salario < 999.99)
                        {
                            novosal = salario + (0.15f * salario);
                            Console.WriteLine("O novo salário será: R$" + novosal);
                        }
                        else if (salario >= 1000 && salario <= 2000)
                        {
                            novosal = salario + (0.1f * salario);
                            Console.WriteLine("O novo salário será: R$" + novosal);
                        }
                        else if (salario > 2000)
                        {
                            novosal = salario + (0.05f * salario);
                            Console.WriteLine("O novo salário será: R$" + novosal);
                        }
                        break;
                    case 2:
                        Console.WriteLine("informe o seu salário");
                        salario = float.Parse(Console.ReadLine());
                        while (salario < 0)
                        {
                            Console.WriteLine("Salário inválido\n Informe o salário novamente");
                            salario = float.Parse(Console.ReadLine());
                        }
                        ferias = salario + salario / 3;
                        Console.WriteLine("o valor de suas férias será: R$" + ferias);
                        break;
                    case 3:
                        Console.WriteLine("informe o seu salário");
                        salario = float.Parse(Console.ReadLine());
                        while (salario < 0)
                        {
                            Console.WriteLine("Salário inválido\n Informe o salário novamente");
                            salario = float.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Informe o tempo em meses que você trabalha na empresa");
                        tempo = int.Parse(Console.ReadLine());
                        while (tempo > 12)
                        {
                            Console.WriteLine("Tempo inválido\n Informe o tempo novamente");
                            tempo = int.Parse(Console.ReadLine());
                        }
                        sal13 = salario * tempo / 12;
                        Console.WriteLine("O valor do seu 13° salário é: R$" + sal13);
                        break;
                }                                              
            } while (opcao != 4);
              Console.ReadLine();
        }
    }
}
