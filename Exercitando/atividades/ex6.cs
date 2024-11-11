using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class ex6
    {
        public void exerc6()
        {
            Console.Clear();
            Console.WriteLine("Seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine("Seu IMC: " + imc);
            exibir exibir = new exibir();
            exibir.Receba();
        }
    }
}
