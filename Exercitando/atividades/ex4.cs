using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class ex4
    {
        public void exerc4()
        {
            Console.Clear();
            Console.WriteLine("escreva seu número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 1)
            {
                Console.WriteLine("Número positivo.\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
            else if (numero <= -1)
            {
                Console.WriteLine("Número negativo.\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
            else
            {
                Console.WriteLine("Seu número é zero.\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
        }
    }
}
