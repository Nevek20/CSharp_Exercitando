using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class ex1
    {
        public void exerc1()
        {
            Console.Clear();
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade <= 17)
            {
                Console.WriteLine("Você é de menor.\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
            else if (idade >= 18)
            {
                Console.WriteLine("você é de maior.\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
        }
    }
}
