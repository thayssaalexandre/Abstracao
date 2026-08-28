namespace Abstracao
{
    public class ContaBancaria
    {
        public string Nome;
        public int NumeroConta;
        public double Saldo;
        public double Deposito;
        public double Retirada;
        public void ExibirInformacoes()
        {
            double TotalDeposito = Saldo + Deposito;
            double TotalRetirada = TotalDeposito - Retirada;
            if (TotalDeposito >= Retirada)
            {
                Console.WriteLine($"Nome do Titular: {Nome}");
                Console.WriteLine($"Número da Conta: {NumeroConta}, Saldo: {Saldo}");
                Console.WriteLine($"Deposito:R${Deposito}, Saldo atualizado: {TotalDeposito}");
                Console.WriteLine($"Retirada: R${Retirada}, Retirada com o saldo atualizado: {TotalRetirada}");
                Console.WriteLine($"------------------------");
            }
            else
            {
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Número da Conta: {NumeroConta}, Saldo: {Saldo}");
                Console.WriteLine($"Deposito:R${Deposito}, Saldo atualizado: {TotalDeposito}");
                Console.WriteLine($"Retirada: R${Retirada}, Retirada com o saldo atualizado: Não Foi Possível a Retirida do valor solicitado");
                Console.WriteLine($"------------------------");
            }
        }
    }
}