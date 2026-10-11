namespace Aula19Dojo_2
{
    public class IngressoVIP : Ingresso
    {
        public float Adicional { get; set; }

        public void MostrarValorVip(){
        float ValorVip = Valor + Adicional;
        System.Console.WriteLine( $"O valor do ingresso VIP é {ValorVip}");
        }
    }
}