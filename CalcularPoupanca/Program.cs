using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPoupancaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor_Investido = 1000;
            int cont = 1;
            while (cont <= 12)
            {
                Valor_Investido = Valor_Investido + Valor_Investido * 0.0036;
                Console.WriteLine("Após " + cont + " mês, você tera R$ " + Valor_Investido);
                cont++;
            }
            Console.ReadLine();
        }
    }
}
