namespace exemplopoo.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Documento { get; set; }

        public virtual void Apresentar () // virtual permite a sobrescrita do método
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}