using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> carrinho = new List<Produto>();
            
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto(1, "celular", 120.99f);
            Produto p2 = new Produto(2, "computador", 30.000f);
            Produto p3 = new Produto(3, "sorvete", 15f);
            Produto p4 = new Produto(4, "escova de dente", 9.99f);
            
            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

            cart.Remover(p2);

            Produto p5 = new Produto(1, "Celeste", 154f);
            cart.Alterar(1, p4);

        
            cart.MostrarTotal();


        }
    }
}
