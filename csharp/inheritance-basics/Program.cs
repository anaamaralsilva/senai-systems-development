using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           CPF cpf = new CPF();
           cpf.nome = "Ana";
           System.Console.WriteLine( cpf.Saudar() );
        }
    }
}
