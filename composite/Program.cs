using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Cria itens simples
        var novo = new ItemSimples("Novo");
        var abrir = new ItemSimples("Abrir");
        var salvar = new ItemSimples("Salvar");
        var sair = new ItemSimples("Sair");

        // Cria item composto "Arquivo"
        var menuArquivo = new MenuComposto("Arquivo");
        menuArquivo.Adicionar(novo);
        menuArquivo.Adicionar(abrir);
        menuArquivo.Adicionar(salvar);
        menuArquivo.Adicionar(sair);

        // Cria item composto "Editar"
        var copiar = new ItemSimples("Copiar");
        var colar = new ItemSimples("Colar");
        var menuEditar = new MenuComposto("Editar");
        menuEditar.Adicionar(copiar);
        menuEditar.Adicionar(colar);

        // Menu principal
        var menuPrincipal = new MenuComposto("Menu Principal");
        menuPrincipal.Adicionar(menuArquivo);
        menuPrincipal.Adicionar(menuEditar);

        // Exibe toda a estrutura
        menuPrincipal.Exibir();
    }
}