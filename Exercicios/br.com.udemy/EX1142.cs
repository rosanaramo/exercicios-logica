using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1142
    {


        public void Calcula()
        {
            
            for(int i=1; i <= 7; i++)
            {

                int variavel = i*4;
                Console.WriteLine((variavel-3) + " "+ (variavel-2) + " "+(variavel-1)+" PUM");
            }
            Console.ReadLine();
             
        }
    }
}
