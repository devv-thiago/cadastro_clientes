using System.Reflection.Metadata.Ecma335;

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
        bool sairPrograma = false;

        while (!sairPrograma)
        {
            Console.WriteLine("Sistema de clientes - Bem vindo!");
            Console.WriteLine("1-Listar clientes\n2-Adicionar\n3-Remover\n4-Sair");
            int operacao = int.Parse(Console.ReadLine());
            Menu opcao = (Menu)operacao;
            switch (opcao)
            {
                case Menu.Listagem:
                    listarRegistros();
                    Console.WriteLine("\nPressione ENTER para voltar para o Menu principal.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case Menu.Adicionar:
                    adicionarRegistro();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case Menu.Remover:
                    removerRegistro();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case Menu.Sair:
                    Console.WriteLine();
                    sairPrograma = true;
                    break;
            }
        }

    }
    static void listarRegistros()
    {
        foreach(var cliente in clientes)
        {
            Console.WriteLine($"Nome cliente: {cliente.nome} - E-mail cliente: {cliente.email} - Telefone cliente: {cliente.telefone}");
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
        Console.WriteLine("Novo cliente adicionado com sucesso!");
    }
    static void removerRegistro()
    {
        Console.WriteLine("--Exclusão de Clientes--");
        Console.Write("Digite o nome do cliente: ");
        string nomeCliente = Console.ReadLine();

        Cliente clienteRemocao = clientes.Find(cliente => cliente.nome == nomeCliente);

        if (clienteRemocao.ToString != null)
        {
            clientes.Remove(clienteRemocao);
            Console.WriteLine("Registro removido com sucesso");
        }
        else
        {
            Console.WriteLine("Cliente não encontrado. Digite um nome válido!");
        }
    }
}
