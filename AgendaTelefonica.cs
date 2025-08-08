using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AgendaTelefonica
    {
        public Dictionary<string, Contato> Agenda { get; set; }

        //public AgendaTelefonica() => Agenda = [];

        //public AgendaTelefonica() => Agenda = new Dictionary<string, Contato>();

        public AgendaTelefonica()
        {
            Agenda = new Dictionary<string, Contato>();
        }

        public void InserirContato(string nome, Contato contato)
        {
            Agenda.Add(nome, contato);
        }

        public Contato BuscarContato(string nome)
        {
            return Agenda[nome];
        }

        public int QtdContatos()
        {
            return Agenda.Count;
        }
    }
}
