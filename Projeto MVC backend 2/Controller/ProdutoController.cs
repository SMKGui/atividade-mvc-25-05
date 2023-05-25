using Projeto_MVC_backend_2.Model;
using Projeto_MVC_backend_2.View;

namespace Projeto_MVC_backend_2.Controller
{
    public class ProdutoController
    {

        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        //metodo controlador para acessar a listagem de produtos

        public void ListarProdutos()
        {
            //chamada da model trazendo a lista
            List<Produto> produtos = produto.Ler();

            //chamada da view passando a lista
            produtoView.Listar(produtos);
        }

        public void Cadastrar()
        {
           Produto novoProduto = produtoView.Cadastrar();

           produto.Inserir(novoProduto);
        }
    }
}