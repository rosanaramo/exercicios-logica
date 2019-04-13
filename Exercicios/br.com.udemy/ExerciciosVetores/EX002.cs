using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy.ExerciciosVetores
{
    class EX002
    {

        int n, contaPares, numero;

        public void Calcula()
        {
            Console.WriteLine("Digite a quantidade de números");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o conjunto de números");
            String[] vetor = new String[n];

            vetor = Console.ReadLine().Split(' ');

            Console.Write("Números Pares: ");
            for (int i =0; i<n; i++)
            {
                numero = Convert.ToInt32(vetor[i]);

                if (numero % 2 ==0)
                {
                    Console.Write(numero + " ");
                    contaPares++;
                }
            }
            Console.WriteLine("Quantidade de Pares: "+ contaPares);
            Console.ReadLine();
        }
    }
}
