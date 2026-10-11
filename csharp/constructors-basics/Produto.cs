namespace Aula16MétodoConstrutor
{
    public class Produto
    {

        public int Codigo { get ; set; }
        public string Nome { get ; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
       
       
        public Produto(int _codigo){
            this.Codigo = _codigo;
        }
            

        public Produto(int codigo, string nome, string descricao, int estoque){
            this.Codigo = codigo;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Estoque = estoque; 
        }

       
    }
}