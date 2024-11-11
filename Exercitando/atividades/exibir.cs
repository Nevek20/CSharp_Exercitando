using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class exibir
    {
        public void Receba()
        {
            Console.WriteLine("Digite 0 para sair do programa.");
            Console.WriteLine("Digite 1 para Exercicios 1.");
            Console.WriteLine("Digite 2 para Exercicios 2.");
            Console.WriteLine("Digite 3 para Exercicios 3.");
            Console.WriteLine("Digite 4 para Exercicios 4.");
            Console.WriteLine("Digite 5 para Exercicios 5.");
            Console.WriteLine("Digite 6 para Exercicios 6.");
            int escolhas = int.Parse(Console.ReadLine());

            switch (escolhas)
            {
                case 1:
                    ex1 ex1 = new ex1();
                    ex1.exerc1();
                    break;
                case 2:
                    ex2 ex2 = new ex2();
                    ex2.exerc2();
                    break;
                case 3:
                    ex3 ex3 = new ex3();
                    ex3.exerc3();
                    break;
                case 4:
                    ex4 ex4 = new ex4();   
                    ex4.exerc4();
                    break;
                case 5:
                    ex5 ex5 = new ex5();    
                    ex5.exerc5();
                    break;
                case 6:
                    ex6 ex6 = new ex6();
                    ex6.exerc6();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    Thread.Sleep(2530);
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Receba();
                    break;
            }
        }
    }
}
