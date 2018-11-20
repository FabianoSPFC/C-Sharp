using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 70;

                if (idade >= 65)
                    Console.WriteLine("Vote se quiser!");
                else if (idade >= 16)
                    Console.WriteLine("Pode Votar!");
                else if (idade <16)
                    Console.WriteLine("Não pode votar!");
                Console.ReadLine();
            }
        }
    }
