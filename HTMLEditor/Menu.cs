using System.Reflection.Metadata;
using System.Runtime.InteropServices;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Draw();
        WriteOptions();
        
        var option = short.Parse(Console.ReadLine()!);
        HandleMenuOption(option);
    }

    public static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("View"); break;
            case 0:
                {
                    Console.Clear();
                    Console.WriteLine("Exit");
                    System.Environment.Exit(0);
                    break;
                }
            default: Show(); break;
        }
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("HTML Editor");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("".PadRight(20, '='));
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Select an option");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - Create new file");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Open file");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("0 - Exit");
        Console.SetCursorPosition(3, 10);
        Console.Write("Option: ");


    }

    public static void Draw()
    {
        DrawPad();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("|".PadRight(40, ' ') + "|");
        }
        DrawPad();
    }

    private static void DrawPad()
    {
        Console.WriteLine("+".PadRight(40, '-') + "+");
    }
}