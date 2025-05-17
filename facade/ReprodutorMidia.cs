using System;

// Classe que representa o Reprodutor de Mídia
public class ReprodutorMidia
{
    public void Ligar() => Console.WriteLine("Reprodutor de mídia ligado.");

    public void Reproduzir(string filme)
        => Console.WriteLine($"Reproduzindo filme: {filme}");

    public void Desligar() => Console.WriteLine("Reprodutor de mídia desligado.");
}

