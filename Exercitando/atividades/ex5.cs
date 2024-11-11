using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class ex5
    {
        public void exerc5()
        {
            Console.Clear();
            Console.WriteLine("Digite seu número");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Seu número é par.\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
            else
            {
                Console.WriteLine("Seu número é ímpar.\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
        }
    }
}
