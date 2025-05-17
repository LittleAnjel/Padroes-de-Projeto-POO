using System;

// Decorador que adiciona chocolate
public class ComChocolate : BebidaDecorator
{
    public ComChocolate(IBebida bebida) : base(bebida) { }

    public override string Descricao()
    {
        return bebida.Descricao() + " e chocolate";
    }

    public override double Custo()
    {
        return bebida.Custo() + 2.0;
    }
}

