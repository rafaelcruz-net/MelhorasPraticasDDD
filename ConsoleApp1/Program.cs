using Domain.Cliente.Aggregate.Builder;
using Domain.Cliente.Aggregate.Entity;
using Domain.Cliente.Aggregate.Factory;
using Domain.Cliente.Aggregate.ValueObject;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new ClienteBuilder()
                                 .Criar("Rafael Cruz", "090454656", new DateTime(2020, 09, 20))
                                 .AdicionarPassword("687987")
                                 .AdicionarEndereco(new Endereco())
                                 .AdicionarTelefone(new Telefone() { Numero = new Numero("99999"), Tipo = Domain.Cliente.Aggregate.Enum.Tipo.Comercial })
                                 .Build();

            cliente.AdicionarPassword("abcd#123");

            Console.WriteLine(cliente.Password.Valor);

            Console.ReadKey();
        }
    }
}
