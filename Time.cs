namespace Abstracao
{
    public class Time
    {
        public string NomeDoTime;
        public List<Jogador> ListaDeJogadores = [];

        public void AdicionarJogador(Jogador jogador)
        {
            ListaDeJogadores.Add(jogador);
            Console.WriteLine($"O jogador {jogador.Nome} foi adicionado ao time {NomeDoTime}.");
        }

        public void ListarJogadores()
        {
            Console.WriteLine($"Escalação do time {NomeDoTime}:");
            foreach (var jogador in ListaDeJogadores)
            {
                Console.WriteLine($"Nome: {jogador.Nome}, Posição: {jogador.Posicao}, Número da Camisa: {jogador.NumeroCamisa}");
            }
        }
    }
}
