public class Funcionario
{
    public string Cargo { get; set; }
    public double Salario { get; set; }

    public void Trabalhar()
    {
        Console.WriteLine("Trabalhando...");
    }
}