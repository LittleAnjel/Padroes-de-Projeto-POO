using System;

// Classe Facade que oferece uma interface simplificada
public class HomeTheaterFacade
{
    private Projetor projetor;
    private SistemaSom som;
    private ReprodutorMidia reprodutor;

    // Construtor da facade recebe as dependências dos subsistemas
    public HomeTheaterFacade(Projetor projetor, SistemaSom som, ReprodutorMidia reprodutor)
    {
        this.projetor = projetor;
        this.som = som;
        this.reprodutor = reprodutor;
    }

    // Método de alto nível que encapsula a complexidade
    public void AssistirFilme(string filme)
    {
        Console.WriteLine("Preparando para assistir ao filme...");
        projetor.Ligar();           // Liga o projetor
        som.Ligar();                // Liga o sistema de som
        reprodutor.Ligar();         // Liga o reprodutor
        reprodutor.Reproduzir(filme); // Começa a reprodução do filme
    }

    // Outro método de alto nível para encerrar a sessão
    public void EncerrarFilme()
    {
        Console.WriteLine("Encerrando sessão...");
        reprodutor.Desligar();      // Desliga o reprodutor
        som.Desligar();             // Desliga o som
        projetor.Desligar();        // Desliga o projetor
    }
}

