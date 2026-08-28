using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int QtdEstoque;

        public void ExibirInformacao()
        {
            Console.WriteLine($"Produto: {Nome}\n Preço: R${Preco}\n Quantidade em estoque: {QtdEstoque}");
            Console.WriteLine("-------------------------------");
        }
    }
}
