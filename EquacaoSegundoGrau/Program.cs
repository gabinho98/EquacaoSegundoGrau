using System;

namespace EquacaoSegundoGrau
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 0;
            //recebendo informações do usuario
            Console.WriteLine("Equação de segundo grau(ax² +bx + c = 0)");
            Console.WriteLine("Digite o valor de A: ");
             a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());


            //calculo valor delta
            double delta = Math.Pow(b,2) - 4*a*(-c);

            
            //delta positivo e negativo
            double xpositivo = (-(b) + Math.Sqrt(delta)) / (2 * a);
            double xnegativo = (-(b) - Math.Sqrt(delta)) / (2 * a);


            //delta maior e igual a zero
            if (delta >= 0)
            {
               if(delta == 0)
                {
                    Console.WriteLine($"A raiz de x' é {xpositivo}");
                }
                else
                {
                    Console.WriteLine($"A raiz de x' é {xpositivo}");
                    Console.WriteLine($"A raiz de x'' é {xnegativo}");
                }
            }
         //delta negativo
         else
            {
                Console.WriteLine("Não há raiz real.");

            }
        }
    }
}
