public class Carro{
    public string Marca;
    public string Modelo;
    public int Ano;
    public string Cor;
    public bool Ligado;

    public void Ligar(){
        Ligado = true;
        Console.WriteLine($"{Marca} {Modelo} está Ligado!");      
    }

    public void Desligar(){
        Ligado = false;
        Console.WriteLine($"{Marca} {Modelo} está Desligado!");      
    }

    public void ExibirInformacoes(){
        Console.WriteLine($"Marca: {Marca}\n");
        Console.WriteLine($"Modelo: {Modelo}\n");
        Console.WriteLine($"Ano: {Ano}\n");
        Console.WriteLine($"Cor: {Cor}\n");
        Console.WriteLine($"Ligado: {Ligado}\n");
    }

}

