using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class ExNomeAlturaIdade
    {

        int n;
        String [] nomes;
        int [] idades;
        double [] alturas;

        public void Calcula()
        {
            n = Convert.ToInt32(Console.ReadLine());
            idades = new int[n];
            alturas = new double[n];
            nomes = new string[n];

            for (int i =0; i<n; i++)
            {
                String[] aux = Console.ReadLine().Split(' ');
                nomes[i] = aux[0];
                idades[i] = Convert.ToInt32(aux[1]);
                alturas[i] = Convert.ToDouble(aux[2], CultureInfo.InvariantCulture);
            }

            // Cálculo da idade média

            double somaAlturas =0, alturaMedia = 0;
            for (int i = 0; i<n; i++)
            {
                somaAlturas = somaAlturas + alturas[i];
            }
            alturaMedia =(double) somaAlturas / n;
            Console.WriteLine("Altura média: " + alturaMedia.ToString("f2", CultureInfo.InvariantCulture));

            // Porcentagem das Pessoas menores de 16 anos

            int contador =0;
            for (int i = 0; i<n; i++)
            {
                if (idades[i]<16)
                {
                    contador++;
                }
            }
            double porcentagem = (double)contador / n * 100.0;
            Console.WriteLine("Porcentagem de pessoas abaixo dos 16 anos:" + porcentagem.ToString("f2", CultureInfo.InvariantCulture) + " %");
            Console.ReadLine();
        }
        
    }
}
