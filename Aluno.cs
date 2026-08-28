namespace Abstracao
{
    public class Aluno
    {
        public string Nome;
        public int Matricula;
        public double Nota1;
        public double Nota2;

        public void CalcularMedia()
        {
           double media = (Nota1 + Nota2)/2;
           Console.WriteLine($"Aluna(o): {Nome}\nNúmero da matrícula: {Matricula}\nNotas: {Nota1} || {Nota2}");
           Console.WriteLine($"Média do aluno: {media}");
        }

    }
       
}
