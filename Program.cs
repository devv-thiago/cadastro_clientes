using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

internal class Program
{

    struct Cliente {
        public string nome;
        public string email;
        public string telefone;

         public Cliente(string nome, string email, string telefone)
        {
            this.nome = nome;
            this.email = email; 
            this.telefone = telefone;
        }
    }

    static List<Cliente> clientes = new List<Cliente>(); 
    enum Menu{Listagem = 1, Adicionar = 2, Remover = 3, Sair = 4 }
    private static void Main(string[] args)
    {
        Console.WriteLine("Sistema de clientes - Bem vindo!");
        Console.WriteLine("1-Listar clientes\n2-Adicionar\n3-Remover\n4-Sair");
        int operacao = int.Parse(Console.ReadLine());
        Menu opcao = (Menu)operacao;
        bool sairPrograma = false;

        while (!sairPrograma)
        {
            switch (opcao)
            {
                case Menu.Listagem:
                    Console.WriteLine();
                    break;
                case Menu.Adicionar:
                    adicionarRegistro();
                    break;
                case Menu.Remover:
                    
                    Console.WriteLine();
                    break;
                case Menu.Sair:
                    Console.WriteLine();
                    sairPrograma = true;
                    break;
            }
        }

    }
    static void adicionarRegistro()
    {
        Console.WriteLine("--Cadastro de Clientes--");
        Console.Write("Digite o nome do cliente: ");
        string nomeCliente = Console.ReadLine();
        Console.Write("Digite o email do cliente: ");
        string emailCliente = Console.ReadLine();
        Console.Write("Digite o telefone do cliente: ");
        string telefoneCliente = Console.ReadLine();
        Cliente novoCliente = new Cliente(nomeCliente, emailCliente, telefoneCliente);
        clientes.Add(novoCliente);
    }
}