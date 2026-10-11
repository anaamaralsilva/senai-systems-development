using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    public class Carrinho : ICarrinho
    {

        List<Produto> carrinho = new List<Produto>();

        public float ValorTotal { get; private set; }

        public void MostrarTotal()
        {
            foreach(Produto item in carrinho)
            {
                ValorTotal += item.Preco;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Valor Total: R$ {ValorTotal} ");
            Console.ResetColor();
        }


        public void Alterar(int _cod, Produto _produtoAlterado)
        {
            carrinho.Find(A => A.Codigo == _cod).Nome = _produtoAlterado.Nome;
            carrinho.Find(B => B.Codigo == _cod).Preco = _produtoAlterado.Preco;
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Ler()
        {
           foreach(Produto item in carrinho){
               System.Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
           }
        }

        public void Incluir(Produto _produto)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Produto _produto)
        {
            throw new NotImplementedException();
        }
    }
}