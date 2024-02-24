/* 
    Um programa que permita ao usuário abrir um arquivo e editar o texto. 
    Salve o texto em um novo arquivo.
*/

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Abrir um arquivo");
    Console.WriteLine("2 - Criar um arquivo");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");
    short opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1: Abrir(); break;
        case 2: Editar(); break;
        case 0: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}
static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Qual caminho do arquivo?");
    var path = Console.ReadLine();
    try
    {
        using (var sr = new StreamReader(path))
        {
            string texto = sr.ReadToEnd();
            Console.WriteLine(texto);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Não foi possível abrir o arquivo {path}");
        Console.WriteLine(e.Message);
    }
    Console.ReadLine();
    Menu();
};
static void Editar()
{
    Console.Clear();
    Console.WriteLine("Digite o seu texto abaixo. (ESC para sair)");
    Console.WriteLine("-----------------------------");
    string texto = "";
    do
    {
        texto += Console.ReadLine();
        texto += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(texto);
};
static void Salvar(string texto)
{
    Console.Clear();
    Console.WriteLine("Qual caminho deseja salvar o arquivo?");
    var path = Console.ReadLine();
    try
    {
        using (var sw = new StreamWriter(path))
        {
            sw.Write(texto);
        }
        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Menu();
    }
    catch (Exception e)
    {
        Console.WriteLine($"Não foi possível salvar o arquivo {path}");
        Console.WriteLine(e.Message);
    }
};

Menu();