using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente Novo = new Cliente();
            Novo.Nome = "Fabiano";
            Novo.Profissao = "Programador;";
            Novo.CPF = "xxxxxxx-xx";
            ClassContaCorrente conta = new ClassContaCorrente(5,10);           
            conta.Titular = Novo;            
            

            Console.WriteLine("Titular: " + Novo.Nome  + "\nAgência: "+ conta.Agencia + "\nNúmero: " + conta.Numero + "\nSaldo: " + conta.Saldo);

            Cliente nome = new Cliente();
            nome.Nome = "Jorge";

            ClassContaCorrente novo = new ClassContaCorrente(8,30);
            novo.Titular = nome;
            novo.Sacar(50);

            Console.WriteLine("\nTitular: " +Novo.Nome + "\nSaldo Anterior: " + conta.Saldo + "\nNovo Saldo: " + novo.Saldo + "\nMeu CPF é: "+ conta.Titular.CPF);

            novo.Depositar(500);
            Console.WriteLine("\nTitular: " + nome.Nome + "\nSaldo Anterior: " + conta.Saldo + "\nNovo Saldo: " + novo.Saldo);

            Console.WriteLine("\n\nSaldo de Fabiano antes da trasnferência: " + conta.Saldo + "\nSaldo de Jorge antes da trasnferência: " + novo.Saldo);           

            novo.Transferir(300, conta);
            Console.WriteLine("\n\nSaldo de Fabiano depois da trasnferência: " + conta.Saldo + "\nSaldo de Jorge depois da trasnferência: " + novo.Saldo);
            Console.WriteLine("\n\nForam criadas " + ClassContaCorrente.TotalContas + " contas");
            Console.ReadLine();
        }
    }
}
