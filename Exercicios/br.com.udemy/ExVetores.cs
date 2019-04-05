using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class ExVetores
    {
        public void Calcula()
        {
            int N;
            double soma =0, media;
            N = Convert.ToInt32(Console.ReadLine());
            String[] numeros = new String[N];

            numeros = Console.ReadLine().Split(' ');

            for (int i =0; i< N; i++)
            {
                soma = soma + Convert.ToDouble(numeros[i]);
            }

            media = soma / N;
            Console.WriteLine("Media: "+ media.ToString("f2"));
            Console.ReadLine();
        }       
    }
}
