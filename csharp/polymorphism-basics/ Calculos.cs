namespace Aula11Polimorfismo
{
    public class  Calculos
    {
        private string semana2;
        private string atraso;
        private string pagamento;

        public string Calcular(){
            return  "Calcular os relatorios semanais";
        }
        public string Calcular(int relatorio){
            return "O relatorio da semana1 é " + semana2;
        }
        public string Calcular(int Atraso, int Pagamento){
            return "O relatorio é " + (atraso+pagamento);
        }
        public string Calcular(string nome, string sobrenome){
            return $"Mostrar nome completo";
        } 
    }
}