
class Program
{
    static void Main()
    {
        // Cria instâncias dos subsistemas
        Projetor projetor = new Projetor();
        SistemaSom som = new SistemaSom();
        ReprodutorMidia reprodutor = new ReprodutorMidia();

        // Cria o objeto Facade passando os subsistemas
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(projetor, som, reprodutor);

        // Usa o Facade para realizar operações complexas de forma simples
        homeTheater.AssistirFilme("QUE MATÉRIA DIFICIL PROFESSOR FERNANDO");

        Console.WriteLine(); // Apenas para separar a saída visualmente

        homeTheater.EncerrarFilme();
    }
}
