namespace Aula08Abstracao
{
    public class  Cartao : Pagamento
    {
        private string token = "sd7fgsdfgsd9g87sdf87gsfg";
        public string bandeira { get; set; }
        public int numero { get; set; }
        public string titular { get; set; }
        public string cvv { get; set; }

        public bool validarToken(){
            if(token != null){
            return true;
            }
        
        return false;
        }
    
    }
}