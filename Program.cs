namespace Abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuFusca = new Carro();

            meuFusca.Marca = "VolksWagen";
            meuFusca.Modelo = "Fusca";
            meuFusca.Ano = 1975;
            meuFusca.Cor = "Azul";

            Console.WriteLine("Informações do meu carro");
            meuFusca.ExibirInformacoes();

            Carro carroVizinho = new Carro();
            carroVizinho.Marca = "Fiat";
            carroVizinho.Modelo = "Uno";
            carroVizinho.Ano = 2010;
            carroVizinho.Cor = "Prata";

            Console.WriteLine("----------------------");
            Console.WriteLine("Informações do carro do vizinho");
            carroVizinho.ExibirInformacoes();

            //EXERCÍCIO 1   

            Produto produtoA = new Produto();

            produtoA.Nome = "Caneta";
            produtoA.Preco = 3.50;
            produtoA.QtdEstoque = 50;

            Console.WriteLine("--Informações do Produto--");
            Console.WriteLine();
            produtoA.ExibirInformacao();


            Produto produtoB = new Produto();

            produtoB.Nome = "Caneta";
            produtoB.Preco = 3.50;
            produtoB.QtdEstoque = 50;

            Console.WriteLine("--Informações do Produto--");
            Console.WriteLine();
            produtoA.ExibirInformacao();
            

        }
    }
}
