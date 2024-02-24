using System.Reflection.Metadata;
using System.Text;

public static class Editor
{
    public static void Show() { 
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("EDITOR MODE");
        Console.WriteLine("Press ESC to return to the menu");
        Console.WriteLine("---------------------------");
        Start();
    }

    public static void Save(string file)
    {
        Console.WriteLine("Enter the file path to save the file:");
        var fullPath = Console.ReadLine()!;
        try
        {
            using (var writer = new StreamWriter(fullPath))
            {
                writer.Write(file);
            }
        } catch (Exception e)
        {
            Console.WriteLine("An error occurred while saving the file");
            Console.WriteLine(e.Message);
        }
    }
    public static void Start() { 
        var file = new StringBuilder();
        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        Console.WriteLine("---------------------------");
        Console.WriteLine(" Do you want to save the file? (y/N)");
        var yes = "y";
        var no = "n";
        var answer = Console.ReadLine()! ?? no;

        if (answer.Equals(yes, StringComparison.OrdinalIgnoreCase))
        {
            Save(file.ToString());
            Console.WriteLine("File saved!");
            Menu.Show();
        }
        else if (string.Equals(answer, no, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("File not saved");
            Menu.Show();
        }
        else
        {
            Console.WriteLine("Invalid option");
            Menu.Show();
        }
    }
}