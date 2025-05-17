using System;

// Decorador que adiciona leite
public class ComLeite : BebidaDecorator
{
    public ComLeite(IBebida bebida) : base(bebida) {}

    public override string Descricao()
    {
        return bebida.Descricao() + " com leite";
    }

    public override double Custo()
    {
        return bebida.Custo() + 1.5;
    }
}

