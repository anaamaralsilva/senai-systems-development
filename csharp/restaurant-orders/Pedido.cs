namespace Aula20ExercicioDeFixação
{
    public class Pedido
    {
       
        public string Itens { get; set; }
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
       public bool PedidoPago { get; set; }



        public string EntregarPedido()
        {
            return $"Pedido entregue pelo: {Restaurante}, para o(a) Cliente {Cliente}";
        }

    }
}