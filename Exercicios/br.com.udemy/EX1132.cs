using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1132
    {

        public void Calcula()
        {
            int x, y, soma=0,troca;

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());


            if (x>y)
            {
                troca = x;
                x = y;
                y = troca;
            }
            for (int i=x; i<=y; i++)
            {
                if (i%13 !=0 )
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
