using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1153
    {

        public void Calcula()
        {
            int N, fatorial=0;
            N = Convert.ToInt32(Console.ReadLine());

            if (N>0 && N<13)
            {
                fatorial = N;
                for (int i = N; i>1; i-- )
                {
                    
                    fatorial = fatorial * (i-1);
                }
            }
            Console.WriteLine(fatorial);
            
        }
    }
}