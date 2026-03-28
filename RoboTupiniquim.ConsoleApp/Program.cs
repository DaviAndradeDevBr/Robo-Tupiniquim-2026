namespace RoboTupiniquim.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Robo.Configurar(1, 2, 'N');


        Console.WriteLine("-------------------------------");
        Console.WriteLine("Robô Tupiniquim");
        Console.WriteLine("-------------------------------");
        
        Console.WriteLine($"Posição inicial: {Robo.posicaoX} {Robo.posicaoY} {Robo.orientacao}");

        Robo.EecutarComando("EMEMEMEMM");
        
        Console.WriteLine($"Posição final: {Robo.posicaoX} {Robo.posicaoY} {Robo.orientacao}");
        Console.ReadLine();

    }
}
