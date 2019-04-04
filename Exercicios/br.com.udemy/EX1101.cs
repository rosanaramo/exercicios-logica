using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1101
    {

        public void Calcula()
        {

            int m =1, n=1, troca, soma =0;
            string[] numeros;

        

            while ((m>0) && (n > 0))
            {
                numeros = Console.ReadLine().Split(' ');
                m = Convert.ToInt32(numeros[0]);
                n = Convert.ToInt32(numeros[1]);

                if (m > n)
                {
                    troca = m;
                    m = n;
                    n = troca;
                }

                if (m>0 && n>0)
                {
                    for (int i = m; i <= n; i++)
                    {
                        soma = soma + i;
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("Sum=" + soma);
                    soma = 0;
                }
                             
            }         
        }       
    }
}
