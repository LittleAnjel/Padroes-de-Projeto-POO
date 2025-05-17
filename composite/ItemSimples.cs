using System;
using System.Collections.Generic;

// Item simples do menu, como "Salvar", "Sair"
public class ItemSimples : IMenuItem
{
    private string nome;

    public ItemSimples(string nome)
    {
        this.nome = nome;
    }

    public void Exibir(int nivel = 0)
    {
        Console.WriteLine(new string(' ', nivel * 2) + "- " + nome);
    }
}