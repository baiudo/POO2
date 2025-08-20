using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
  private static void Main(string[] args)
  {
    while (true)
    {
      Console.WriteLine("Qual operação de conversão você deseja? \n1 - Celsius -> Fahrenheit \n2 - Fahrenheit -> Celsius \n3 - Celsius -> Kelvin \n4 - Kelvin -> Celsius \n0 - Sair");
      int conversor = int.Parse(Console.ReadLine());
      if (conversor == 0)
      {
          break;
      } else if (conversor == 1)
      {
          Console.WriteLine("Digite a temperatura em Celsius: ");
          float tempC = float.Parse(Console.ReadLine());
          float CtoF = (float)(tempC * 1.8 + 32);
          Console.WriteLine($"{tempC:F2}ºC é o mesmo que {CtoF}ºF");
      } else if (conversor == 2)
      {
          Console.WriteLine("Digite a temperatura em Fahrenheit: ");
          float tempF = float.Parse(Console.ReadLine());
          float FtoC = (float)((tempF - 32)/1.8);
          Console.WriteLine($"{tempF:F2}ºF é o mesmo que {FtoC}ºC");
      } else if (conversor == 3)
      {
          Console.WriteLine("Digite a temperatura em Celsius: ");
          float tempC = float.Parse(Console.ReadLine());
          float CtoK = (float)(tempC + 273.15);
          Console.WriteLine($"{tempC:F2}ºF é o mesmo que {CtoK:F2}K");
      } else if (conversor == 4)
      {
          Console.WriteLine("Digite a temperatua em Kelvin: ");
          float tempK = float.Parse(Console.ReadLine());
          float KtoC = (float)(tempK - 273.15);
          Console.WriteLine($"{tempK:F2}K é o mesmo que {KtoC}ºC");
      } else
      {
          continue;
      }
    }
  }
}
