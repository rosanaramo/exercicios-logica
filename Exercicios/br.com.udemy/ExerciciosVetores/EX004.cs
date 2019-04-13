using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy.ExerciciosVetores
{
    class EX004
    {
        int n;
        double total, media;
        public void Calcula()
        {
            n = Convert.ToInt32(Console.ReadLine());
            String[] vetor = new string[n];
            vetor = Console.ReadLine().Split(' ');

            for (int i=0; i<n; i++)
            {
                total = total + Convert.ToDouble(vetor[i]);
            }
            media = total / n;

            Console.Write("Números abaixo da média: ");
            for (int i = 0; i < n; i++)
            {
                int numero = Convert.ToInt32(vetor[i]);
                if (numero< media)
                {
                    Console.Write(numero+ " ");
                }
            }

            Console.ReadLine();

        }
    }
}
