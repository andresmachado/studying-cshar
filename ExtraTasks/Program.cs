using OtherTasksNamespace;

void AllOperations(float a, float b) {
    Console.WriteLine("Addition: " + (a + b));
    Console.WriteLine("Subtraction: " + (a - b));
    Console.WriteLine("Multiplication: " + (a * b));
    Console.WriteLine("Division: " + (a / b));
}

void BandList() {
    List<string> bandas = new List<string>();

    bandas.Add("Iron Maiden");
    bandas.Add("Megadeth");
    bandas.Add("Rotting Christ");
    bandas.Add("Katatonia");

    foreach (var banda in bandas) {
        Console.WriteLine(banda);
    }
}

void CalcListNumbers() {
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int sum = 0;

    for (int i = 0; i < numbers.Count; i++) {
        sum += numbers[i];
    }
    Console.WriteLine("Sum: " + sum);
}

AllOperations(10, 5);
BandList();
CalcListNumbers();
DateTimeType.ExampleDateTime();
DateTimeType.Culture();
Currency.ExampleCurrency();
ExampleLists.Lists();
Exceptions.ExampleExceptions();