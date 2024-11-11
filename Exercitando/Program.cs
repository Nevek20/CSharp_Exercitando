using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cab cab = new cab();
            cab.Cabecalho();
            exibir exibir = new exibir();
            exibir.Receba();
        }
    }
}
