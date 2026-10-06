namespace CadastroAluno
{
    public class Celular
    {
        public string modelo;
        public int tamanho;
        public bool ligado;

        /// <summary>
        /// ligado
        /// </summary>
        /// <returns>ligado</returns>
        public string ligado(){
            return "ligando";
        
        }
        /// <summary>
        /// desligado
        /// </summary>
        /// <returns>desligado ou ligado</returns>
        public string Desligado(){
            return "Desligado";
        }
        /// <summary>
        /// ligação
        /// </summary>
        /// <returns>fazer ligacao</returns>
        public string FezerLigacao(){
            return "Chamando";

        }
        /// <summary>
        /// texto
        /// </summary>
        /// <returns>enviar mensagem</returns>
        public string EnviarMensagem(){
            return "mensagem enviada";
        }
    }
}
