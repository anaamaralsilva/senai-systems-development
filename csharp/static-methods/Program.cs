using System;

namespace Aula22MetodosEstáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Conversor.CotacaoDolar = 5.29f;//

            Console.WriteLine(Conversor.ConverterDolarParaReal(100) );
            Console.WriteLine(Conversor.ConverterRealParaDolar(5) );
        }
    }
}
