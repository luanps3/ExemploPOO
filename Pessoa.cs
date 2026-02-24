public class Pessoa
{
    public string Nome { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public string CPF { get; set; }
    public string CEP { get; set; }

    public void Respirar()
    {
        Console.WriteLine("Respirando...");
    }

    public string Falar()
    {
        return "Falando...";
    }

    public void Andar()
    {
        Console.WriteLine("Andando...");
    }

}