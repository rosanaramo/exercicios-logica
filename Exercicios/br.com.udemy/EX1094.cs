using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.br.com.udemy
{
    class EX1094
    {

        
        
        public void Calcula()
        {
            int N;
            double ps =0, pr =0, pc =0 , c =0 , r =0, s =0, totalCobaias= 0;
            N = Convert.ToInt32(Console.ReadLine());
            for (int i =0; i<N; i++)
            {
                String [] valores = Console.ReadLine().Split(' ');
                if (valores[1]=="C")
                {
                    c = c + Convert.ToDouble(valores[0]);
                }
                if (valores[1] == "R")
                {
                    r = r + Convert.ToDouble(valores[0]);
                }
                if (valores[1] == "S")
                {
                    s = s + Convert.ToDouble(valores[0]);
                }

                totalCobaias = totalCobaias + Convert.ToInt32(valores[0]);
            }

            Console.WriteLine("Total: "+ totalCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: "+ c);
            Console.WriteLine("Total de ratos: " + r);
            Console.WriteLine("Total de ratos: " + s);

            pc = (c * 100) / totalCobaias;
            ps = (s * 100) / totalCobaias;
            pr = (r * 100) / totalCobaias;

            Console.WriteLine("Percentual de coelhos: "+pc.ToString("f2")+" %");
            Console.WriteLine("Percentual de ratos: " + pr.ToString("f2") + " %");
            Console.WriteLine("Percentual de sapos: " + ps.ToString("f2") + " %");
            Console.ReadLine();
        }
    }
}
