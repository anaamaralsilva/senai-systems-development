namespace Aula20ExercicioDeFixação
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string Endereco { get; set; }

        public Cliente( string _Ana){
            this.NomeCliente = _Ana;
        }

       
        public string MostrarDados(){
            return $"Cliente: {NomeCliente}, Endereco{Endereco}";
        }
    }
}