using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1067
    {
        public void Calcula()
        {
            int X = 0;

            X = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=X; i++ )
            {
                if (X>=1 && X<=1000)
                {
                   if(i%2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
