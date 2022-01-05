namespace exemplopoo.models
{
    public class Diretor : Professor
    {
        public override void Apresentar () // override sobrescreve o método
        {
            Console.WriteLine($"Diretor");
        }
    }
}