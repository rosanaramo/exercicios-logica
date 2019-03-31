using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class Ex1073
    {

        
        public void Calcula()
        {

            Double N = 0;
            N = Convert.ToDouble(Console.ReadLine());

            if (N>5 && N<2000)
            {
                for (int i=1; i<=N; i++)
                {
                    if (i%2 ==0)
                    {
                        Console.WriteLine(i+"^2 = "+Math.Pow(i,2));
                    }
                }
            }
        }
    }
}
