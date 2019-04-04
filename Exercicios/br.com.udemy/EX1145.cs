using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1145
    {


        public void Calcula()
        {
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            if (x>1 && x<20 && x<y&&y< 100000 )
            {
                for (int i = 1; i <= y;)
                {
                    for (int j = 1; j <= x; j++)
                    {
                        if (j == x)
                        {
                            Console.Write(i);
                        }
                        else
                        {

                            Console.Write(i + " ");
                        }
                        i++;
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
        
    }
}
