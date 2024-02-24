using System.Text.RegularExpressions;

public class Viewer
{
    public static void Show(string file)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("VIEWER MODE");
        Console.WriteLine("Press ESC to return to the menu");
        Console.WriteLine("---------------------------");
        Replace(file);
        Console.WriteLine("---------------------------");
        Console.WriteLine("Press any key to return to the menu");
        Console.ReadKey();
        Menu.Show();
    }

    public static void Replace(string text)
    {
        var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        var words = text.Split(' ');

        foreach (var word in words)
        {
            if (strong.IsMatch(word))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(
                    word.Substring(word.IndexOf('>') + 1,
                    (
                        (word.LastIndexOf('<') - 1) - word.IndexOf('>')
                    )
                ));
                Console.Write(" ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(word + " ");
            }
        }
    }
}