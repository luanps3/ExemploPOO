public class Funcionario:Pessoa
{
    public string Cargo { get; set; }
    public double Salario { get; set; }

    public void Trabalhar()
    {
        Console.WriteLine("Trabalhando...");
    }
}