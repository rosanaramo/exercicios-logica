using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1099
    {

        
        public void Calcula()
        {
            int N, x, y, troca;
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=N; i++)
            {
                String[] numeros = Console.ReadLine().Split(' ');
                x = Convert.ToInt32(numeros[0]);
                y = Convert.ToInt32(numeros[1]);

                if (x>y)
                {
                    troca = x;
                    x = y;
                    y = troca;

                }

            }

        
        }
    }
}
