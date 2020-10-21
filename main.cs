using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    string carroEconomico;
    double consumoTeste, acharConsumoL, valorGasto;

    List<string> carros_Nome = new List<string>();
    List<double> carros_Consumo = new List<double>();

    carros_Nome.Add("Fusca");
    carros_Consumo.Add(15);
    carros_Nome.Add("Gol");
    carros_Consumo.Add(20);
    carros_Nome.Add("Ferrari");
    carros_Consumo.Add(10);

    carroEconomico = "Teste";
    consumoTeste = carros_Consumo[0];

    for (int i = 0; i < carros_Nome.Count; i++ )
    {
      if (carros_Consumo[i] > consumoTeste)
      {
        consumoTeste = carros_Consumo[i];
        carroEconomico = carros_Nome[i];
      }
    }
    Console.WriteLine("O carro mais economico é o " + carroEconomico);

    for (int i = 0; i < carros_Nome.Count; i++)
    {
      acharConsumoL = 1000/carros_Consumo[i];
      valorGasto = acharConsumoL * 4.89;

      Console.WriteLine("Carro "+ carros_Nome[i] +", quantos KM por litro que irá rodar "+ acharConsumoL +", Valor gastará R$"+ valorGasto);
    }

    Console.WriteLine("============================");
    /* Solução do professor */

    string continuar = "s", marca;
    double consumo;

    Carro auto = new Carro("Teste", 0);
    List<Carro> listaCarros = new List<Carro>();

    while(continuar == "s")
    {
      Console.WriteLine("Marca do carro:");
      marca = Console.ReadLine();
      Console.WriteLine("KM/L do carro:");
      consumo = double.Parse(Console.ReadLine());
      auto = new Carro(marca, consumo);
      listaCarros.Add(auto);
      Console.WriteLine("Continuar S/N?");
      continuar = Console.ReadLine();
    }

    // Cria uma variavel abstrata do tipo "Carro".
    Carro menor_consumo = listaCarros[0];

    for(int i = 1; i < listaCarros.Count; i++)
    {
      if(listaCarros[i].getConsumo() > menor_consumo.getConsumo())
      {
        menor_consumo = listaCarros[i];
      }
    }
    Console.WriteLine("Marca de menor consumor "+ menor_consumo.getMarca() +" Consumo de "+ menor_consumo.getConsumo() +"KM/L");

    for(int i = 0; i < listaCarros.Count; i++)
    {
      Console.WriteLine("Marca "+ listaCarros[i].getMarca());
      Console.WriteLine("Litros gastos em 1000KM: "+ 1000 / listaCarros[i].getConsumo());
      Console.WriteLine("Valor gasto a percorrer 1000 KM: "+ (1000 / listaCarros[i].getConsumo()) * 4.89);
    }
  }
}