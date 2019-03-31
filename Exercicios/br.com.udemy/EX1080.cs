using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1080
    {
        
        public void Calcula()
        {
            int numero=0, maior=0, posicao=0;
            for (int i = 1; i<=100; i++)
            {
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero>maior)
                {
                    maior = numero;
                    posicao = i;
                }
                
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
