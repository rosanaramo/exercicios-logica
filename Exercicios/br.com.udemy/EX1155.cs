using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1155
    {
        public void Calcula()
        {
            double s =0;
            for (int i =1; i<=100; i++)
            {
                s = s + (1 / (double)i);
            }
            Console.WriteLine(s.ToString("f2"));
            Console.ReadLine();
        }
        
    }
}
