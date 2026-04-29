/*
Especificação
A Agência Espacial Brasileira (AEB) contratou a Academia do Programador para desenvolver o software de guia
do Robô Tupiniquim I, que fará análises em Marte. O robô explorará uma área retangular dividida em um grid.
Sobre o Sistema
● Posição e Orientação: A posição do robô é dada por coordenadas (X, Y) e uma letra que representa a
direção para onde ele está olhando (Norte, Sul, Leste, Oeste).
● Comandos: A AEB envia strings de comando simples (E, D, M):
1. E (Esquerda) e D (Direita) fazem o robô virar 90 graus, sem sair do lugar.
2. M (Mover) move o robô uma posição no grid para frente, mantendo a direção.

Exemplo:
Input:
Digite a posição inicial: 1 2 N
Digite a sequência de comandos: EMEMEMEMM

Output Esperado:
Posição alcançada: 1 3 N

O programa receberá os comandos de exploração em duas partes para o robô:
1. A posição inicial, dada por 2 inteiros (X e Y) e uma letra (Orientação), separados por espaços.
2. Uma série de instruções (E, D, M) que o robô deve seguir.
Após mover o robô, o programa deve retornar sua posição final (X Y) e sua orientação.
Dica:
Para quebrar o comando em um array de instruções separadas utilize o método ToCharArray()
string comando = "EMEMEMEMM";
char[] instrucoes = comando.ToCharArray()
*/
using System;

class Grid
{
    public static void DesenharGrid(int x, int y, char direcao)
    {
        int min = -6;
        int max = 5;

        for (int linha = max; linha >= min; linha--)
        {
            Console.Write(" ");

            for (int coluna = min; coluna <= max; coluna++)
            {
                if (coluna == x && linha == y)
                {
                    Console.Write(direcao + " ");
                }
                else if (coluna == 0 && linha == 0)
                {
                    Console.Write("0 ");
                }
                else if (coluna == -6 && linha == 0)
                {
                    Console.Write(" X ");
                }
                else if (coluna == 0 && linha == -6)
                {
                    Console.Write("Y ");
                }
                else if (coluna == 0)
                {
                    Console.Write("| ");
                }
                else if (linha == 0)
                {
                    Console.Write("- ");
                }
                else if (coluna == -6 && linha == 5)
                {
                    Console.Write(" 5 ");
                }
                else if (coluna == -6 && linha == 4)
                {
                    Console.Write(" 4 ");
                }
                else if (coluna == -6 && linha == 3)
                {
                    Console.Write(" 3 ");
                }
                else if (coluna == -6 && linha == 2)
                {
                    Console.Write(" 2 ");
                }
                else if (coluna == -6 && linha == 1)
                {
                    Console.Write(" 1 ");
                }
                else if (coluna == -6 && linha == -1)
                {
                    Console.Write("-1 ");
                }
                else if (coluna == -6 && linha == -2)
                {
                    Console.Write("-2 ");
                }
                else if (coluna == -6 && linha == -3)
                {
                    Console.Write("-3 ");
                }
                else if (coluna == -6 && linha == -4)
                {
                    Console.Write("-4 ");
                }
                else if (coluna == -6 && linha == -5)
                {
                    Console.Write("-5 ");
                }
                else if (coluna == 1 && linha == -6)
                {
                    Console.Write("1");
                }
                else if (coluna == 2 && linha == -6)
                {
                    Console.Write(" 2");
                }
                else if (coluna == 3 && linha == -6)
                {
                    Console.Write(" 3");
                }
                else if (coluna == 4 && linha == -6)
                {
                    Console.Write(" 4");
                }
                else if (coluna == 5 && linha == -6)
                {
                    Console.Write(" 5");
                }
                else if (coluna == -1 && linha == -6)
                {
                    Console.Write("-1 ");
                }
                else if (coluna == -2 && linha == -6)
                {
                    Console.Write("-2");
                }
                else if (coluna == -3 && linha == -6)
                {
                    Console.Write("-3");
                }
                else if (coluna == -4 && linha == -6)
                {
                    Console.Write("-4");
                }
                else if (coluna == -5 && linha == -6)
                {
                    Console.Write("-5");
                }
                else if (coluna == -6 && linha == -6)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(". ");
                }
            }

            Console.WriteLine();
        }

        Console.Write("    ");

        for (int i = min; i <= max; i++)
        {
            Console.Write(" ");
        }
    }
}

class Comandos
{
    public static void ProcessarComandos(char[] instrucoes, ref int x, ref int y, ref char orientacao)
    {
        for (int i = 0; i < instrucoes.Length; i++)
        {
            char comando = instrucoes[i];

            if (comando == 'E')
            {
                // Virar à esquerda
                if (orientacao == 'N')
                {
                    orientacao = 'O';
                }
                else if (orientacao == 'O')
                {
                    orientacao = 'S';
                }
                else if (orientacao == 'S')
                {
                    orientacao = 'L';
                }
                else if (orientacao == 'L')
                {
                    orientacao = 'N';
                }
            }
            else if (comando == 'D')
            {
                // Virar à direita
                if (orientacao == 'N')
                {
                    orientacao = 'L';
                }
                else if (orientacao == 'L')
                {
                    orientacao = 'S';
                }
                else if (orientacao == 'S')
                {
                    orientacao = 'O';
                }
                else if (orientacao == 'O')
                {
                    orientacao = 'N';
                }
            }
            else if (comando == 'M')
            {
                // Mover para frente
                if (orientacao == 'N')
                {
                    y++;
                }
                else if (orientacao == 'S')
                {
                    y--;
                }
                else if (orientacao == 'L')
                {
                    x++;
                }
                else if (orientacao == 'O')
                {
                    x--;
                }
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Bem-vindo ao Robô Tupiniquim I!");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            
            int x = 0;
            int y = 0;
            char orientacao = 'N';
            
            // Solicita a posição inicial do robô
            Console.Write("Digite a Posição Inicial de X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Digite a Posição Inicial de Y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Digite a Orientação Inicial (N, S, L, O): ");
            orientacao = char.Parse(Console.ReadLine().ToUpper());

            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Posição Inicial: {x} {y} {orientacao}");
            Console.WriteLine();
            Grid.DesenharGrid(x, y, orientacao);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();

            // Solicita a sequência de comandos
            Console.Write("Digite a Sequência de Comandos: ");
            string comandos = Console.ReadLine().ToUpper();
            char[] instrucoes = comandos.ToCharArray();

            Comandos.ProcessarComandos(instrucoes, ref x, ref y, ref orientacao);

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Posição Alcançada: {x} {y} {orientacao}");
            Console.WriteLine();
            Grid.DesenharGrid(x, y, orientacao);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("Gostaria de Realizar Outra Exploração? (S/N)");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Encerrando o Programa. Até a Próxima Exploração!");
                break;
            }
        }
    }
}