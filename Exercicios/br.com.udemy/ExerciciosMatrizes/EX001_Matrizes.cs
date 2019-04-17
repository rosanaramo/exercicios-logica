using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy.ExerciciosMatrizes
{
    class EX001Matrizes
    {

       public void Calcula()
        {
            int n;
            int[,] a;
            n = int.Parse(Console.ReadLine());
            a = new int[n, n];

            for (int i =0; i<n; i++)
            {

                String[] s = Console.ReadLine().Split(' ');
                for (int j=0; j<n; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i=0; i<n; i++)
            {
                Console.WriteLine(a[i,i]);
                
            }

            Console.WriteLine("Números Negativos: ");

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j<n; j++)
                {
                    if (a[i,j]<0)
                    {
                        Console.WriteLine(a[i, j] + " ");
                    }
                }
            }

            Console.ReadLine();
         }
    }
}
