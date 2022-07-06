using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_ContadorFor_PauloAraujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Contador---");
            for(int i = 1; i <= 50 ; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---Fim da Contagem---");
            Console.ReadKey();
        }
    }
}
