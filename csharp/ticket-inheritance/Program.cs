using System;

namespace Aula19Dojo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVIP bilhete = new IngressoVIP();
            bilhete.Valor = 50f;
            bilhete.Adicional = 45f;
            bilhete.ImprimirValor();
            bilhete.MostrarValorVip();

            System.Console.WriteLine($"A diferença entre eles é de {bilhete.Adicional}");
            
        }
    }
}
