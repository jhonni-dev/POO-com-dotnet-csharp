namespace exemplopoo.models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor; // base informa que está alterando a classe herdada
        }
    }
}