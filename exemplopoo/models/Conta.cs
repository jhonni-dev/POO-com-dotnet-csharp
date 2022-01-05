namespace exemplopoo.models
{
    public abstract class Conta
    {
        protected double saldo;
        public abstract void Creditar(double valor);
        public void ExibirSaldo() // Não é abstrato e tem implementação
        {
            System.Console.WriteLine("Seu saldo é R$" + saldo);
        }
    }
}