namespace exemplopoo.models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }
        public override void Apresentar () // override sobrescreve o método
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e meu salário é R${Salario}");
        }
    }
}