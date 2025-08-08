using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contato c01 = new ("Vinicius", "123", "Prof", 0);
            Contato c02 = new ("Matheus", "456", "Prof", 10);
            Contato c03 = new ("Marta", "789", "Vizinha", 20);

            AgendaTelefonica ag = new();

            ag.InserirContato(c01.Nome, c01);
            ag.InserirContato(c02.Nome, c02);
            ag.InserirContato(c03.Nome, c03);

            Console.WriteLine(ag.BuscarContato("Marta").Apelido);
            Console.WriteLine($"Minha agenda tem {ag.QtdContatos()} contatos");
        }
    }
}
