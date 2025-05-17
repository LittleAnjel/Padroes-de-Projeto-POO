using System;

// Classe abstrata que implementa a interface e serve de base para os decoradores
public abstract class BebidaDecorator : IBebida
{
    protected IBebida bebida;

    public BebidaDecorator(IBebida bebida)
    {
        this.bebida = bebida;
    }

    public abstract string Descricao();
    public abstract double Custo();
}

