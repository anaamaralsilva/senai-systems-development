using System;

namespace Aula18Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador messi = new Jogador();
            messi.Nome = "Lionel Messi";
            messi.Posicao = "Atacante";
            messi.Nascimento = DateTime.Parse("24/06/1987");
            messi.MostrarDados();
            
            System.Console.WriteLine(value: messi.CalcularIdade() );
            System.Console.WriteLine( messi.CalcularAposentadoria() );

        }
        
    }
}

