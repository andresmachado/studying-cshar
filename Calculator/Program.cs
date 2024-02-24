
static void Soma()
{
    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    float result = valor1 + valor2;
    Console.WriteLine($"O resultado da soma é: {result}");
    Console.ReadKey();
    Calculator();
}

static void Subtracao()
{
    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    float result = valor1 - valor2;
    Console.WriteLine($"O resultado da subtração é: {result}");
    Console.ReadKey();
    Calculator();
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    float result = valor1 * valor2;
    Console.WriteLine($"O resultado da multiplicação é: {result}");
    Console.ReadKey();
    Calculator();
}

static void Divisao()
{
    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float valor2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    float result = valor1 / valor2;
    Console.WriteLine($"O resultado da divisão é: {result}");
    Console.ReadKey();
    Calculator();
}

static void Calculator()
{
    Console.Clear();

    Console.WriteLine("Escolha uma operação: ");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("-------------------------");
    short opcao = short.Parse(Console.ReadLine()); // short é um tipo de dado que ocupa menos memória que o int

    switch (opcao)
    {
        case 1:
            Soma();
            break;
        case 2:
            Subtracao();
            break;
        case 3:
            Multiplicacao();
            break;
        case 4:
            Divisao();
            break;
        case 0:
            Console.WriteLine("Até logo!");
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
Calculator();