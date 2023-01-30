using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BancoImpacta
{
    internal class Conta
    {
        public int Nconta;
        public string Titular;
        public decimal Saldo;
        


        public Conta(int nconta)
        {
            this.Nconta = nconta;

        }
        public Conta(int nconta, string titular)
        {
            this.Nconta = nconta;
            this.Titular = titular;
        }
        /* destrutor
       ~Conta()
        {
           console.WriteLine ("Objeto finalizado")
        }*/

        public void ExibirSaldo()
        {
            Console.WriteLine($"Numero da conta: {Nconta}\n Titular: {Titular}\n  Saldo: {Saldo:c}");
        }
        public void Sacar(decimal valor)
        {

            if (Saldo == 0)
            {
                Console.Write(" Não possui saldo disponivel para saque");
            }
            else if (valor > Saldo)
            {
                Console.WriteLine(" Valor do saque superior ao saldo disponivel conta ");
            }
            else
            {
                Saldo = Saldo - valor;
            }
        }
        public void ExibirSaldoSaque()
        {

            Console.WriteLine($"Saque realizado com sucesso!\n Saldo disponivel: {Saldo:c}");
        }
        public void Depositar(decimal valor)
        {
            Saldo = Saldo + valor;
        }

        public void Transferir(Conta destino, decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo Insuficiente \n Transferência não Realizada");
            }
            else
            {
                Saldo = Saldo - valor;
                destino.Saldo = destino.Saldo + valor;
            }

        }

    }
}