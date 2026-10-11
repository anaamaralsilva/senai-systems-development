using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos relatorio = new Calculos();

            // Sem argumentos
            System.Console.WriteLine(relatorio.Calcular());

            // Com 1 argumento int
            System.Console.WriteLine(relatorio.Calcular(120));

            // Com 2 argumentos int
            System.Console.WriteLine(relatorio.Calcular(120, 30));

            // Com 2 argumentos string
            System.Console.WriteLine(relatorio.Calcular("Hanna", "Montana"));


        }
    }
}
