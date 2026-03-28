namespace RoboTupiniquim.ConsoleApp;

/*
    ● Posição e Orientação: A posição do robô é dada por coordenadas (X, Y) e uma
    letra que representa a direção para onde ele está olhando (Norte, Sul, Leste, Oeste).
    
    ● Comandos: A AEB envia strings de comando simples (E, D, M):
        1. E (Esquerda) e D (Direita) fazem o robô virar 90 graus, sem sair do lugar.
        2. M (Mover) move o robô uma posição no grid para frente, mantendo a direção.

*/


static class Robo
{
    public static int posicaoX = 1;
    public static int posicaoY = 2;
    public static char orientacao = 'N';


    public static void Configurar(int pX, int pY, char ort)
    {
        posicaoX = pX;
        posicaoY = pY;
        orientacao = ort;
    }

    public static void EecutarComando(string comandoCompleto)
    {
        for (int contador = 0; contador < comandoCompleto.Length; contador++)
        {
            char comandoAtual = comandoCompleto[contador];

            
            if (comandoAtual == 'E')
                GirarParaEsquerda();
            
            else if (comandoAtual == 'D')
                GirarParaDireita();
            
            else if (comandoAtual == 'M')
                Avancar();
        }
    }

    public static void Avancar()
    {
        if (orientacao == 'N') posicaoY++;
        else if (orientacao == 'S') posicaoY--;
        else if (orientacao == 'O') posicaoX--;
        else if (orientacao == 'L') posicaoX++;
    }
    
    public static void GirarParaEsquerda()
    {
        if (orientacao == 'N') orientacao = 'O';
        else if (orientacao == 'O') orientacao = 'S';
        else if (orientacao == 'S') orientacao = 'L';
        else if (orientacao == 'L') orientacao = 'N';
    }


    public static void GirarParaDireita()
    {
        if (orientacao == 'N') orientacao = 'L';
        else if (orientacao == 'L') orientacao = 'S';
        else if (orientacao == 'S') orientacao = 'O';
        else if (orientacao == 'O') orientacao = 'N';
    }
}

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
