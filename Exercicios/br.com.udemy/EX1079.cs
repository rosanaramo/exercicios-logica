using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1079
    {

        
        public void Calcula()
        {
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            double valor01, valor02, valor03, media;


            for (int i =1; i<=N; i++)
            {
                String[] valores = Console.ReadLine().Split(' ');
                valor01 = Convert.ToDouble(valores[0]);
                valor02 = Convert.ToDouble(valores[1]);
                valor03 = Convert.ToDouble(valores[2]);

                media = ((valor01 * 2.00)+ (valor02 * 3.00) + (valor03 * 5.00))/(2.00+3.00+5.00);
                Console.WriteLine(Math.Round(media,1));
            }
          
        }
    }
}
