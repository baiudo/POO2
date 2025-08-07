using System;
using System.Collections.Generic;

public class AgendaTelefonica
{
    private Dictionary<string, string> colecao;

    public AgendaTelefonica()
    {
        colecao = new Dictionary<string, string>();
    }

    public void Inserir(string nome, string numero)
    {
        // Verifica se o nome já existe como chave no dicionário
        if (colecao.ContainsKey(nome))
        {
            // Se existir, apenas atualiza o número
            colecao[nome] = numero;
            Console.WriteLine($"Contato '{nome}' atualizado.");
        }
        else
        {
            // Se não existir, adiciona o novo contato
            colecao.Add(nome, numero);
            Console.WriteLine($"Contato '{nome}' inserido.");
        }
    }

    /// Busca e retorna o número de um contato a partir do nome.
    public string BuscarNumero(string nome)
    {
        // O método TryGetValue é eficiente para buscar um valor sem causar erro se a chave não existir.
        if (colecao.TryGetValue(nome, out string numeroEncontrado))
        {
            return numeroEncontrado;
        }

        return "Contato não encontrado.";
    }

    public void Remover(string nome)
    {
        if (colecao.Remove(nome))
        {
            Console.WriteLine($"\nContato '{nome}' removido com sucesso.");
        }
        else
        {
            Console.WriteLine($"\nFalha ao remover: Contato '{nome}' não encontrado.");
        }
    }

    /// Retorna a quantidade total de contatos na agenda.
    public int Tamanho()
    {
        return colecao.Count;
    }

    /// Método auxiliar para exibir todos os contatos (não estava no diagrama, mas útil para testes).
    public void ListarTodos()
    {
        Console.WriteLine("\n--- Agenda Telefônica ---");
        if (Tamanho() == 0)
        {
            Console.WriteLine("A agenda está vazia.");
        }
        else
        {
            foreach (var contato in colecao)
            {
                Console.WriteLine($"Nome: {contato.Key} | Número: {contato.Value}");
            }
        }
        Console.WriteLine("-------------------------\n");
    }

  Inserir("Ricardo", "21992561528");
  Inserir("Bianca", "61952017491");
  Inserir("Gustavo", "27904189361");
  Inserir("Thiago", "219998765432");
  Inserir("Diana", "24966271082");
}
