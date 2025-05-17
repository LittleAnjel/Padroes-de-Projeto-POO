using System;

// Implementação concreta de uma bebida: Café
public class Cafe : IBebida
{
    public string Descricao()
    {
        return "Café";
    }

    public double Custo()
    {
        return 5.0;
    }
}