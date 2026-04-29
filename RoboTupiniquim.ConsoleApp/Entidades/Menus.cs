
class Menus
{
    public static void MenuInicial()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Bem-vindo ao Robô Tupiniquim I!");
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine();
    }

    public static void MenuFinal(ref int x, ref int y, ref char orientacao)
    {
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine($"Posição Alcançada: {x} {y} {orientacao}");
        Console.WriteLine();
        Grid.DesenharGrid(x, y, orientacao);
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------");
    }
}

