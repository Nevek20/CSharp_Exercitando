using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class ex2
    {
        public void exerc2()
        {
            Console.Clear();
            Console.WriteLine("Nota do aluno: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota <= 4)
            {
                Console.WriteLine("Reprovado\n");
                exibir exibir = new exibir();   
                exibir.Receba();
            }
            else if (nota == 5 || nota == 6)
            {
                Console.WriteLine("Recuperação\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
            else if (nota >= 7)
            {
                Console.WriteLine("Aprovado\n");
                exibir exibir = new exibir();
                exibir.Receba();
            }
        }
    }
}
