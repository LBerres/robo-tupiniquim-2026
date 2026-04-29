
class Comandos
{
    public static void ProcessarComandos(ref int x, ref int y, ref char orientacao)
    {
        Console.Write("Digite a Sequência de Comandos: ");
        string comandos = Console.ReadLine().ToUpper();
        char[] instrucoes = comandos.ToCharArray();

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

