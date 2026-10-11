using System;

namespace Aula16MétodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
           Produto maquiagem = new Produto(485);

           Produto babyliss = new Produto(3689);
           System.Console.WriteLine(babyliss.Codigo);


           System.Console.WriteLine();


           Produto tenis = new Produto(452,  "Puma",  "Couro", 35);
           System.Console.WriteLine(tenis.Codigo);
           System.Console.WriteLine(tenis.Nome);
           System.Console.WriteLine(tenis.Descricao);
           System.Console.WriteLine(tenis.Estoque);
        }
    }
}
