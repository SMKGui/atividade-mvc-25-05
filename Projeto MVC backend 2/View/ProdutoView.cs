using Projeto_MVC_backend_2.Model;

namespace Projeto_MVC_backend_2.View
{
    public class ProdutoView
    {
        //metodo para exibir os dados
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}");
            }
        }
        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o codigo: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome: ");
            novoProduto.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe o preço: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;            
        }
    }
}