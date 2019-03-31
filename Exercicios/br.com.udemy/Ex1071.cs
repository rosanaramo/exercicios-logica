using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class Ex1071
    {
        public void Calcula()
        {
            int x= 0;
            int y = 0;
            int soma = 0;
            int maior = 0;
            int menor = 0;

            x = Convert.ToInt32(Console.ReadLine());
            y= Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                maior=x;
                menor = y;
            }
            else
            {
                menor = x;
                maior = y;
            }

            for (int i = menor+1; i<maior; i++)
            {

                if(i%2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);              

            soma = 0;
            Console.ReadLine();
        }
    }
}
