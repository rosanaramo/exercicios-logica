using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1143
    {

        
        public void Calcula()
        {

            int variavel;
            variavel = Convert.ToInt32(Console.ReadLine());
            
            for ( int i = 1; i<= variavel; i++)
            {
                if (variavel>1 && variavel<100)
                {
                    Console.WriteLine((i) + " " + (i * i) + " " + (i * i * i));
                }
            }
        }
    }
}
