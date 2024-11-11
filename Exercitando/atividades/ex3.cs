using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class ex3
    {
        public void exerc3()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua escolha:\n\n1.Adição\n2.Subtração\n3.Multiplicação\n4.Divisão");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                Console.WriteLine("sua conta: " + numero1 + " + " + numero2 + " = " + (numero1 + numero2) + "\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
            else if (escolha == 2)
            {
                Console.WriteLine("sua conta: " + numero1 + " - " + numero2 + " = " + (numero1 - numero2) + "\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
            else if (escolha == 3)
            {
                Console.WriteLine("sua conta: " + numero1 + " X " + numero2 + " = " + (numero1 * numero2) + "\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
            else if (escolha == 4)
            {
                Console.WriteLine("sua conta: " + numero1 + " ÷ " + numero2 + " = " + (numero1 / numero2) + "\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
        }
    }
}

