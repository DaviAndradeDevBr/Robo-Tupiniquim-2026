# 🤖 Robô Tupiniquim 

## Introdução

O **Robô Tupiniquim** é um sistema de navegação autônoma desenvolvido para a Agência Espacial Brasileira (AEB). O objetivo é orientar exploradores robóticos em Marte através de um sistema de coordenadas e comandos direcionais em um terreno retangular (grid).

## Sobre o Projeto

Este projeto foi desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net), focando em **Lógica de Programação** e **Programação Estruturada** utilizando C# e .NET.

### Funcionalidades 🕹️

O sistema processa a movimentação do robô baseando-se em três pilares principais:

1.  **Posicionamento Geográfico**: 
    - O robô opera em um plano cartesiano com coordenadas `(X, Y)`.
    - Mantém uma orientação constante para um dos pontos cardeais: `N` (Norte), `S` (Sul), `L` (Leste) ou `O` (Oeste).

2.  **Processamento de Comandos**:
    - **E (Esquerda)**: Gira o robô 90° para a esquerda sem alterar a posição (X, Y).
    - **D (Direita)**: Gira o robô 90° para a direita sem alterar a posição (X, Y).
    - **M (Mover)**: Desloca o robô uma unidade para frente na direção em que ele está apontando.

3.  **Exploração de Área**:
    - O sistema define os limites máximos do terreno para garantir que o robô permaneça dentro da área de análise estipulada.

## Instruções de Uso 💻

1.  Obtenha o código via clone de repositório ou download do arquivo `.zip`.
2.  Acesse o diretório raiz através do terminal.
3.  Utilize o comando abaixo para restaurar as dependências:
    ```bash
    dotnet restore
    ```
4.  Inicie a aplicação:
    ```bash
    dotnet run --project RoboTupiniquim.ConsoleApp


## Requisitos de Sistema

.NET SDK 10.0 ou superior.