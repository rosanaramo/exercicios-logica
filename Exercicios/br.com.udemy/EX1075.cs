using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1075
    {

        
       
        public void Calcula()
        {
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<10000; i++)
            {
                if (i%N == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
