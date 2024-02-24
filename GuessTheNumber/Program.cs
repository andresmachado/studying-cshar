void Welcome() {
    Console.WriteLine("Welcome to the Guess the Number game!");
    Console.WriteLine("I'm thinking of a number between 1 and 100");
    Console.WriteLine("Try to guess it in as few attempts as possible.");
    Console.WriteLine("Good luck!");
}

void Play() {
    Random random = new Random();
    int number = random.Next(1, 101);
    int attempts = 0;
    int guess = 0;

    do {
        Console.Write("\nEnter your guess: ");
        guess = Convert.ToInt32(Console.ReadLine()!);
        attempts++;

        switch (guess.CompareTo(number)) {
            case -1:  // guess < number
                Console.WriteLine("Too low!");
                break;
            case 1:  // guess > number
                Console.WriteLine("Too high!");
                break;
            default:
                Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                break;
        }
    } while (guess != number);

    Console.WriteLine("Press Enter to play again or any other key to exit.");

    if (Console.ReadKey().Key == ConsoleKey.Enter) {
        Console.WriteLine();
        Play();
    }
}

Welcome();
Play();