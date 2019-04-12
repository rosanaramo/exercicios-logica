using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy.ExerciciosVetores
{

    //1) Faça um programa que leia N números reais e armazene-os em um vetor.Em seguida, mostrar na tela o maior número do vetor (supor não haver empates). Mostrar também a posição do maior elemento.
    public class EX001
    {

        int n, posicao;
        double maior, numero;

        public void Calcula()
        {
            Console.WriteLine("Digite a quantidade de valores");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os valores");

            String[] valores = new String[n];
            valores = Console.ReadLine().Split(' ');

            for (int i =0; i<n; i++)
            {
                numero = Convert.ToDouble(valores[i]);
                if (numero>maior)
                {
                    maior = numero;
                    posicao = i;
                }
            }

            Console.WriteLine("Número maior: "+maior);
            Console.WriteLine("Posição: " + (posicao+1));
            Console.ReadLine();
        }
    }
}
