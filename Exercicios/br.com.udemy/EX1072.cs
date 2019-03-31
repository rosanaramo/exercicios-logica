using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1072
    {

        int n = 0, numero = 0, contaIn, contaOut;
        bool fora = false, dentro= false;
        public void Calcula()
        {

            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                numero = Convert.ToInt32(Console.ReadLine());
                for (int j = 10; j <= 20; j++)
                {
                    if (numero == j)
                    {
                        dentro = true;
                        break;
                    }                    
                }
                if (dentro)
                {
                    contaIn++;   
                }
                else
                {
                    contaOut++;
                }

                dentro = false;
                fora = false;
            }
            Console.WriteLine(contaIn + " in");
            Console.WriteLine(contaOut + " out");
        }
    }
}
