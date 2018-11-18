using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPoupancaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor_Investido = 1000;
            for( int i = 1; i <= 12; i++)
            {
                Valor_Investido = Valor_Investido + Valor_Investido * 0.0036;
                Console.WriteLine("Após " + i + " mês, você tera R$ " + Valor_Investido);
            }
            Console.ReadLine();
        }
    }
}
