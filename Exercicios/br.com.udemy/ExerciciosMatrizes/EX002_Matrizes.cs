using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy.ExerciciosMatrizes
{
    class EX002_Matrizes
    {

        int linha, coluna,soma;
        int[,] matriz;
        int[] vetor;
        public void Calcula()
        {
            linha = Convert.ToInt32(Console.ReadLine());
            coluna = Convert.ToInt32(Console.ReadLine());

            matriz = new int[linha, coluna];
            vetor = new int[linha];

            for (int i=0; i<linha; i++)
            {
                String [] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = Convert.ToInt32(valores[j]);
                    soma = soma + matriz[i, j];                   
                }
                vetor[i] = soma;
                soma = 0;
                 
            }
            for (int i = 0; i < coluna; i++)
            {
                Console.WriteLine(vetor[i]+ " ");
            }

            Console.ReadLine();
        }
    }
}
