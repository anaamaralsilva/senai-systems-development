using System.Collections.Generic;
using Aula34MVCConsole.Models;
using Aula34MVCConsole.View;

namespace Aula34MVCConsole.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel    = new Produto();
        ProdutoView produtoView = new ProdutoView();
        
        public void Listar()
        {
            List<Produto> lista = produtoModel.Ler();
            produtoView.MostrarNoConsole(lista);            
        }

        public void Buscar (string preco)
        {
            List<Produto> lista = produtoModel.Ler().FindAll( x => x.Preco == float.Parse(preco) );
            produtoView.MostrarNoConsole(lista);
        }

    }
}