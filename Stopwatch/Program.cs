/*
    This program is a simple countdown timer.
    It takes input in the format of:
    10S = 10 seconds
    10M = 10 minutes
    10H = 10 hours
    0 = Exit
    It will then count down from the given time.
*/

static void Start(int time)
{
    int currentTime = 0;
    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }
    Console.Clear();
    Console.WriteLine("Time is up!");
    Thread.Sleep(2500);
}

static void Exit()
{
    Console.Clear();
    Console.WriteLine("Goodbye!");
    Thread.Sleep(2000);
    Environment.Exit(0);
}

static void CheckTypeAndStart(int time, char type)
{
    switch (type)
    {
        case 's':
            Start(time);
            break;
        case 'm':
            Start(time * 60);
            break;
        case 'h':
            Start(time * 3600);
            break;
        default:
            Console.WriteLine("Invalid input!");
            Thread.Sleep(2000);
            break;
    }
}

static void Menu()
{
    Console.Clear();
    Console.Write("10S = Seconds\n10M = Minutes\n10H = Hours\n0 = Exit\n\nEnter time: ");
    string input = Console.ReadLine().ToLower();
    
    if (input == "0")
    {
        Exit();
    }

    int time = int.Parse(input[..^1]); // Remove last character
    char type = char.Parse(input.Substring(input.Length - 1, 1)); // Get last character

    if (time <= 0)
    {
        Console.WriteLine("Invalid input!");
        Thread.Sleep(2000);
        Menu();
    }

    CheckTypeAndStart(time, type);
    Menu();
}

Menu();
