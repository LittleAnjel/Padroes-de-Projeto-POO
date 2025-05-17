using System;
using System.Collections.Generic;


// Interface comum para itens simples e compostos
public interface IMenuItem
{
    void Exibir(int nivel = 0);
}