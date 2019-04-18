using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy.ExerciciosMatrizes
{
    class Ex003_Matrizes
    {
        int linha, soma, linhaDesejada, coluna;
       
        int[,] matriz; 
        public void Calcula()
        {

            linha = Convert.ToInt32(Console.ReadLine());
            coluna = Convert.ToInt32(Console.ReadLine());

            matriz = new int[linha, coluna];

            for(int i=0; i<linha; i++)
            {

                String[] s = Console.ReadLine().Split(' ');
                for (int j=0; j<coluna; j++)
                {
                    matriz[i, j] = Convert.ToInt32(s[j]);

                    soma = soma + matriz[i, j];
                }
                
            }

            Console.WriteLine("The matrix elements sum is: "+soma);
            Console.WriteLine("Enter the index of the line you desire to sum: ");
            linhaDesejada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elementos da linha desejada: ");

            for (int i=0; i<=linhaDesejada; i++)
            {
                Console.Write(matriz[linhaDesejada,i]+ " ");
            }
            Console.ReadLine();
        }
    }
}
