namespace exemplopoo.models
{
    public class Aluno : Pessoa // Aluno herda de Pessoa
    {
        public int Nota { get; set; }
        public override void Apresentar () // override sobrescreve o método
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota {Nota}");
        }
    }
}