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
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int x = 0;
            int y = 0;
            char orientacao = 'N';

            Menus.MenuInicial();

            Posicao.SolicitarPosicaoInicial(ref x, ref y, ref orientacao);

            Comandos.ProcessarComandos(ref x, ref y, ref orientacao);

            Menus.MenuFinal(ref x, ref y, ref orientacao);

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

