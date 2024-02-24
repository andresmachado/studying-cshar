// Screen Sound

// List<string> savedBands = new List<string>();
Dictionary<string, List<int>> bandRatings = new Dictionary<string, List<int>>();

// This is a function, without the static keyword, that will be called from the Main method.
// https://fsymbols.com/pt/geradores
void WelcomeMenu()
{
    // Strings with @ are called verbatim strings, they ignore escape (\n, \r...) characters.
    string welcomeMessage = "Welcome to Screen Sound!";
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(welcomeMessage);
    ShowMenuOptions();
    CaptureOption();
}

void ShowMenuOptions()
{
    Console.WriteLine("\n1 - Register a band");
    Console.WriteLine("2 - List bands");
    Console.WriteLine("3 - Rate a band");
    Console.WriteLine("4 - Show band rating average");
    Console.WriteLine("0 to Exit");
}

void RegisterBand()
{
    Console.Clear();
    PrintHeader("Register bands.");
    Console.Write("What's the band name: ");

    string bandName = Console.ReadLine()!;
    bandRatings.Add(bandName, new List<int>());

    Console.WriteLine($"Band {bandName} was registered with success!");
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    Console.Clear();
    WelcomeMenu();
}

void ListBands()
{
    Console.Clear();
    PrintHeader("List of registered bands.");

    if (bandRatings.Count == 0)
    {
        Console.WriteLine("No bands registered");
    }
    else
    {
        Console.WriteLine("-".PadRight(20, '-'));
        foreach (var band in bandRatings)
        {
            if (band.Value.Count == 0)
            {
                Console.WriteLine($"{band.Key} - no ratings yet");
                continue;
            }
            else
            {
                Console.WriteLine($"{band.Key} - {band.Value.Average():0.0} stars");
                Console.Write("-".PadRight(20, '-') + "\n");
            }
        }
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    Console.Clear();
    WelcomeMenu();
}

void PrintHeader(string header)
{
    int headerLength = header.Length;
    string headerLine = string.Empty.PadLeft(headerLength, '*');
    Console.WriteLine(headerLine);
    Console.WriteLine(header);
    Console.WriteLine(headerLine + "\n");

}

void RateBand()
{
    // how many stars?
    Console.Clear();
    PrintHeader("Rate a band.");

    // which band?
    Console.Write("Which band do you want to rate: ");
    string bandName = Console.ReadLine()!;

    // if band exists, add rating, if not, show error message and return to the menu
    if (bandRatings.ContainsKey(bandName))
    {
        Console.Write("How many stars do you want to rate this band (1 to 5): ");
        int rating = int.Parse(Console.ReadLine()!);
        bandRatings[bandName].Add(rating);
        Console.WriteLine($"Thanks for rating this band with {rating} stars!");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
        WelcomeMenu();
    }
    else
    {
        Console.WriteLine("Band not found, press any key to continue");
        Console.ReadKey();
        Console.Clear();
        WelcomeMenu();
    }

}

void ShowAverage()
{
    Console.Clear();
    PrintHeader("Show band rating average.");
    if (bandRatings.Count == 0)
    {
        Console.WriteLine("No bands registered");
    }
    else
    {
        Console.Write("Which band do you want to see the rating average: ");
        string bandName = Console.ReadLine()!;
        if (bandRatings.ContainsKey(bandName))
        {
            var selectedBandRatings = bandRatings[bandName];
            Console.WriteLine($"{bandName} - {selectedBandRatings.Average():0.0}");
        }
        else
        {
            Console.WriteLine("Band not found");
        }
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    Console.Clear();
    WelcomeMenu();
}

void CaptureOption()
{
    Console.Write("\nType the option number: ");
    string option = Console.ReadLine()!;
    switch (option)
    {
        case "1":
            RegisterBand();
            break;
        case "2":
            ListBands();
            break;
        case "3":
            RateBand();
            break;
        case "4":
            ShowAverage();
            break;
        case "0":
            Console.WriteLine(@"goodbye! \,,,/(^_^)\,,,/");
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

WelcomeMenu();