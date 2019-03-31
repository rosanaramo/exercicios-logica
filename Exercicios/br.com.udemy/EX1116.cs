using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1116
    {

        

        public void Calcula()
        {
            int N;
            double numero01, numero02, resultado;
            N = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<N; i++)
            {
                String[] valores = Console.ReadLine().Split(' ');
                numero01 = Double.Parse(valores[0]);
                numero02 = Double.Parse(valores[1]);

                if(numero02 != 0)
                {
                    resultado = numero01 / numero02;
                    Console.WriteLine(resultado.ToString("f1"));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
                
                
            }
        
        }
    }
}
