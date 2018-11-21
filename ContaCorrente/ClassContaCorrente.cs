using System;
using ContaCorrente;
//using ContaCorrente; ou como está feita na linha 6

namespace ContaCorrente
{
    public class ClassContaCorrente
    {
        private int agencia;
        private int numero;
        private double saldo = 200;

        public static int TotalContas { get; private set; }
        public int Agencia {
            get
            {
                return agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                agencia = value;
            }
        }
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
         }
       
        public ClassContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalContas++;
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ClassContaCorrente destino)
        {
            if (saldo < valor)
                return false;
            else
            {
                saldo -= valor;
                destino.Depositar(valor);
                return true;
            }
        }
    }
}