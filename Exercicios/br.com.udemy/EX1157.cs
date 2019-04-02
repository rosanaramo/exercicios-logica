using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1157
    {

        public void Calcula()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=N; i++)
            {
                if (N%i  ==0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
