namespace Abstracao
{
    public class Carro
    {
       
        public string Marca;
        public string Modelo;
        public int Ano;
        public string Cor;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}");
            Console.WriteLine($"Cor: {Cor} || Ano: {Ano}");
            
        }
    }
}
