namespace RoboTupiniquim.ConsoleApp;

static class Robo
{
    public static int posicaoX;
    public static int posicaoY;
    public static char orientacao;


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
