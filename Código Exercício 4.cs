using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float X, Y;
            X = 0.1f;
            Y = 0.1f;
            while (X!=0 && Y!=00) 
            {
                Console.WriteLine("Informe a coordenada x");
                X=float.Parse(Console.ReadLine());
                Console.WriteLine("Informe a coordenada y");
                Y=float.Parse(Console.ReadLine());
                if (X>0 && Y>0)
                {
                   Console.WriteLine(X+ " " + Y +  "Primeiro quadrante");
                }

            }
        }
    }
}
