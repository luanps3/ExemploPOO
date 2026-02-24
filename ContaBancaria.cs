public class ContaBancaria
{
    private double saldo;

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

    public void Sacar(double valor)
    {
        if (valor < saldo)
        {
            saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public double ConsultarSaldo()
    {
        return saldo;
    }




}