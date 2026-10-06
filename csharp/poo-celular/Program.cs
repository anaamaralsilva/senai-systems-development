using System;

namespace Celular{
    class Program
    {
        static void Main(string[] args)
        {
            Celular Samsung = new celular();
            Samsung.nome = "Samsung";
            Samsung.modelo = Smartphone;
            Samsung.tamanho = 6.4;
            Samsung.ligado = false;

            Console.WriteLine("Samsung: "+Samsung.ligado());
            Console.WriteLine("Samsung: "+Samsung.Desligado());
            Console.WriteLine("Samsung: "+Samsung.FezerLigacao());
            Console.WriteLine("Samsung: "+Samsung.EnviarMensagem());
        }
    }
}
