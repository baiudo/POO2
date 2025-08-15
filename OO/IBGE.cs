using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<char, List<int>> FaixaIdade = new Dictionary<char, List<int>>();
        Console.WriteLine("Para finalizar o programa, digite um número menor ou igual a 0");
        int idade;
        FaixaIdade.Add('A', new List<int>());
        FaixaIdade.Add('B', new List<int>());
        FaixaIdade.Add('C', new List<int>());
        FaixaIdade.Add('C', new List<int>());
        FaixaIdade.Add('E', new List<int>());
        while (true)
        {
            Console.WriteLine("Digite a idade a ser registrada");
            idade = int.Parse(Console.ReadLine());
            if (idade <= 0)
            {
                break;
            } else if (idade <= 15)
            {
                FaixaIdade['A'].Add(idade);
            } else if (idade <= 30)
            { 
                FaixaIdade['B'].Add(idade);
            } else if (idade <= 45)
            {
                FaixaIdade['C'].Add(idade);
            } else if (idade <= 60)
            {
                FaixaIdade['D'].Add(idade);
            } else
            {
                FaixaIdade['E'].Add(idade);
            }

            int contagemTotalGeral = FaixaIdade.Values.Sum(lista => lista.Count);
            foreach (var id in FaixaIdade)
            {
                char faixa = id.Key;
                List<int> lista = id.Value;

                // Calcula a contagem de itens na lista individual.
                int contagemDaLista = lista.Count;

                // Calcula a porcentagem.
                double porcentagem = (double)contagemDaLista / contagemTotalGeral * 100;

                Console.WriteLine($"A faixa {faixa} tem {contagemDaLista} resgistros e representa {porcentagem:F2}% do total");
            }
        }
    }
}
