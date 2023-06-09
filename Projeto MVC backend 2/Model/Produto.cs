namespace Projeto_MVC_backend_2.Model
{
    public class Produto
    {
        //propriedades
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        //caminho da pasta e do arquivo csv
        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            //criar a logica para gerar a pasta e o arquivo

            //obter o caminho da pasta
            string pasta = PATH.Split("/")[0];

            //verificar se no caminho ja existe uma pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //verificar se no caminho ja existe um arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        //metodo para ler os dados do arquivo csv
        public List<Produto> Ler()
        {
            //instancia da lista produtos
            List<Produto> produtos = new List<Produto>();

            //array de strings armazenando todas as linhas do csv
            string[] linhas = File.ReadAllLines(PATH);

            //leitura das linhas
            foreach (var item in linhas)
            {
                //separacao de atributos de cada linha
                string[] atributos = item.Split(";");

                //instancia de produto
                Produto p = new Produto();

                //atribuicao de valores dentro do objeto
                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                //adiciona objeto dentro da lista
                produtos.Add(p);
            }
            //retorna a lista de produtos
            return produtos;
        }
        //metodo para preparar as linhas a serem inseridas no csv
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";//1020;Coca Zero;6
        }

        //metodo para inserir um produto na linha csv
        public void Inserir(Produto p)
        {
            //array que armazena as linhas obtidas pelo método PrepararLinhasCSV
            string[] linhas = { PrepararLinhasCSV(p) };

            //inserir todas as linhas no arquivo dentro do PATH
            File.AppendAllLines(PATH, linhas);
        }

    }
}