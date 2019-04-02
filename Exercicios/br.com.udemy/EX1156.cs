using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1156
    {

        public void Calcula()
        {
            double s = 0;
            for (int i = 1; i <= 19; i++)
            {
                s = (double)s + (((2*(double)i)+1) /(2*(double)i));
            }
            Console.WriteLine(s.ToString("f2"));          
        }
    }
}
