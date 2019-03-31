using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1097
    {

        public void Calcula()

        {
            
            int j = 7;
            for ( int i=1; i<=9; i= i+2)
            {
                for (int f=1; f<=3; f++)
                {
                    Console.WriteLine("I="+i+ " J="+(j--));
                }

                j = j + 5;
            }
        }
    }
}
