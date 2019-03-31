using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1074
    {

        public void Calcula()
        {
            int N = 0;
            int Numero;
            N =Convert.ToInt32(Console.ReadLine());

            for (int i =0; i<= N; i++)
            {
                Numero = Convert.ToInt32(Console.ReadLine());
                
                if (Numero != 0)
                {
                    if (Numero % 2 == 0)
                    {
                        Console.Write("EVEN ");
                    }
                    else
                    {
                        Console.Write("ODD ");
                    }

                    if (Numero > 0)
                    {
                        Console.WriteLine("POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("NEGATIVE");
                    }
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
