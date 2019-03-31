using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1133
    {

        public void Calcula()
        {
            int x, y,troca;


            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            if (x>y)
            {
                troca = x;
                x = y;
                y = troca;
            }

            for (int i = x+1; i<y; i++)
            {
                if ((i % 5) == 2 || (i % 5) == 3)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
