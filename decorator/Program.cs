using System;

class Program
{
    static void Main()
    {
        // Criando um café simples
        IBebida pedido = new Cafe();
        Console.WriteLine($"{pedido.Descricao()} - R$ {pedido.Custo()}");

        // Adicionando leite ao café
        pedido = new ComLeite(pedido);
        Console.WriteLine($"{pedido.Descricao()} - R$ {pedido.Custo()}");

        // Adicionando chocolate ao café com leite
        pedido = new ComChocolate(pedido);
        Console.WriteLine($"{pedido.Descricao()} - R$ {pedido.Custo()}");
    }
}


