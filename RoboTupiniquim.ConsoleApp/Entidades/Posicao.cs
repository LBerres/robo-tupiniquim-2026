
class Posicao
{
    public static void SolicitarPosicaoInicial(ref int x, ref int y, ref char orientacao)
    {

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
    }
}

