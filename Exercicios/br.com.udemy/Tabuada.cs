using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
       public void Calcula()
       {
            int N =0;
            N = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i<=10; i++)
            {
                if (N>2 && N < 1000)
                {
                    Console.WriteLine(i + " x " + N +" = "+ i * N);
                }
            }
       }
    }
}
