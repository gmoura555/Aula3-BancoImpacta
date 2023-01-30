using System.Security.Cryptography;

namespace BancoImpacta
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Conta c1 = new Conta(1001, "Romulo");
            c1.Depositar(1000);
            c1.ExibirSaldo();
            c1.Sacar(2000);
            c1.ExibirSaldo();


            Conta c2 = new Conta(1002, "Fernando");
            c2.ExibirSaldo();
            c1.Transferir(c2, 200);
            c2.ExibirSaldo();
            c2.Depositar(100);
            c1.ExibirSaldo();
            c1.Transferir(c2, 100);
            c2.ExibirSaldo();
            Console.ReadKey();  
        }
    }
}