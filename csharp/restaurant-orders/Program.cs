using System;

namespace Aula20ExercicioDeFixação
{
    class Program
    {
        
        static void Main(string[] args)
        {
           Restaurante McDonald = new Restaurante ("McDonald");
           Console.WriteLine ( McDonald.MostrarDados());
          
          
          
            Cliente Ana = new Cliente ("Ana");
            Ana.Endereco = "Vila Mariana, 584";
            Console.WriteLine( Ana.MostrarDados());

            
            Pedido pedido = new Pedido();
            pedido.Cliente = Ana.NomeCliente;
            pedido.Restaurante = McDonald.NomeRestaurante;
            Console.WriteLine( pedido.EntregarPedido());
        }
    }
}
