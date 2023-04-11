﻿namespace agrecacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com Agregação");

        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();

        cli.Nome = "Ágatha Louzada";

        cdc.Numero = "123456789";
        cdc.DataValidade = "08/2027";

        cdc.Cliente = cli;

        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é:" + cdc.DataValidade);
        Console.WriteLine("O nome do cartão AGREADO é:" + cdc.Cliente.Nome);
    }
}
