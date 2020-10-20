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
    Console.WriteLine("O carro mais economico " + carroEconomico);

    for (int i = 0; i < carros_Nome.Count; i++)
    {
      acharConsumoL = 1000/carros_Consumo[i];
      valorGasto = acharConsumoL * 4.89;

      Console.WriteLine("Carro "+ carros_Nome[i] +", quantos KM por litro que irá rodar "+ acharConsumoL +", Valor gastará R$"+ valorGasto);
    }

  }
}