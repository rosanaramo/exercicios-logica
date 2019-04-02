using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1144
    {
        public void Calcula()
        {
            int N;

            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<= N; i++)
            {
                Console.WriteLine(i + " "+ (i*i)+" "+ (i*i*i) );
                Console.WriteLine(i + " " +((i * i)+1) + " " + (((i * i * i) +1)));
            }
        }
    }
}