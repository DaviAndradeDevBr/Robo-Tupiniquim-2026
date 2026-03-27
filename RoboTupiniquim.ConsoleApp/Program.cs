namespace RoboTupiniquim.ConsoleApp;

/*
    ● Posição e Orientação: A posição do robô é dada por coordenadas (X, Y) e uma
    letra que representa a direção para onde ele está olhando (Norte, Sul, Leste, Oeste).
    
    ● Comandos: A AEB envia strings de comando simples (E, D, M):
        1. E (Esquerda) e D (Direita) fazem o robô virar 90 graus, sem sair do lugar.
        2. M (Mover) move o robô uma posição no grid para frente, mantendo a direção.

*/

class Program
{
    static void Main(string[] args)
    {
        int posicaoX = 1;
        int posicaoY = 2;
        char orientacao = 'N';

        string comandoCompleto = "EMEMEMEMM";
        
        
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Robô Tupiniquim");
        Console.WriteLine("-------------------------------");
        
        Console.WriteLine($"Posição inicial: {posicaoX} {posicaoY} {orientacao}");

        // algoritmo
        for (int contador = 0; contador < comandoCompleto.Length; contador++)
        {
            char comandoAtual = comandoCompleto[contador];

            

            if (comandoAtual == 'E')
            {
                if (orientacao == 'N') orientacao = 'O';
                else if (orientacao == 'O') orientacao = 'S';
                else if (orientacao == 'S') orientacao = 'L';
                else if (orientacao == 'L') orientacao = 'N';
            }
            else if (comandoAtual == 'D')
            {
                if (orientacao == 'N') orientacao = 'L';
                else if (orientacao == 'L') orientacao = 'S';
                else if (orientacao == 'S') orientacao = 'O';
                else if (orientacao == 'O') orientacao = 'N';
            }
            else if (comandoAtual == 'M')
            {
                if (orientacao == 'N') posicaoY++;
                else if (orientacao == 'S') posicaoY--;
                else if (orientacao == 'O') posicaoX--;
                else if (orientacao == 'L') posicaoX++;
            }
        }
        
        Console.WriteLine($"Posição final: {posicaoX} {posicaoY} {orientacao}");
        Console.ReadLine();

    }
}
