using System;

namespace RelatoriosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Mensal");
            Mensal mensal = new Mensal();
            mensal.relatorio();


            System.Console.WriteLine("Anual");
            Anual anual = new Anual();
            anual.relatorio();

        }
    }
}
