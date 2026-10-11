namespace Aula08Abstracao
{
    public class  CartaoDebito : Cartao
    {
        public float saldo { get; set; }

        public string Transferir(float valor){
            return  $"R$ {valor} Transferido de sua conta";
        }

        public string PagarTitular(){
            return "Título pago com cartão de débito";
        }
    }
}