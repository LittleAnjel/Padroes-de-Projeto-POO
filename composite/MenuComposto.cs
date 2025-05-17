using System;
using System.Collections.Generic;

// Item composto que pode conter outros itens (ex: "Arquivo" com "Novo", "Abrir")
public class MenuComposto : IMenuItem
{
    private string nome;
    private List<IMenuItem> itens = new List<IMenuItem>();

    public MenuComposto(string nome)
    {
        this.nome = nome;
    }

    public void Adicionar(IMenuItem item)
    {
        itens.Add(item);
    }

    public void Remover(IMenuItem item)
    {
        itens.Remove(item);
    }

    public void Exibir(int nivel = 0)
    {
        Console.WriteLine(new string(' ', nivel * 2) + "+ " + nome);
        foreach (var item in itens)
        {
            item.Exibir(nivel + 1); // Indenta os subitens
        }
    }
}