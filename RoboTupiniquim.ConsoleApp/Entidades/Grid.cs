
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

