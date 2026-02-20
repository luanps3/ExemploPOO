// Criei um objeto
Carro carro1 = new();
Carro carro2 = new();

//Atribuindo um valor para uma propriedade do objeto
carro1.Marca = "BMW";
carro1.Modelo = "X1";
carro1.Ano = 2025;
carro1.Cor = "Marrom";
carro1.Ligar();
carro1.Desligar();

//Atribuindo um valor para uma propriedade do objeto
carro2.Marca = "Fiat";
carro2.Modelo = "Toro";
carro2.Ano = 1999;
carro2.Cor = "Vermelho";
carro2.Ligar();
carro2.Desligar();

carro1.ExibirInformacoes();
carro2.ExibirInformacoes();



