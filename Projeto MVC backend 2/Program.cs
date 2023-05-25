using Projeto_MVC_backend_2.Model;
using Projeto_MVC_backend_2.View;
using Projeto_MVC_backend_2.Controller;

Produto p = new Produto();

ProdutoController controller = new ProdutoController();

controller.Cadastrar();

controller.ListarProdutos();
