const string BASE_URL = "https://www.cheapshark.com/api/1.0/deals";

void CheapSharp()
{
    using (HttpClient client = new HttpClient())
    {
        var response = client.GetStringAsync(BASE_URL).GetAwaiter().GetResult();
        Console.WriteLine(response);
    }
    
}

void TryToDivide()
{
    Console.Write("Enter first value: ");
    var value1 = int.Parse(Console.ReadLine()!);
    Console.Write("Enter second value: ");
    var value2 = int.Parse(Console.ReadLine()!);

    try
    {
        var result = value1 / value2;
        Console.WriteLine($"Seu resultado é: {result}");
    } 
    catch (Exception ex)
    {
        Console.WriteLine($"Não foi possivel realizar a sua operação: {ex.Message}");
    }
}


void TryNull()
{
    try
    {
        MinhaClasse objetoNulo = null;
        objetoNulo.Meumetodo();
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }

}

// TryToDivide();
// CheapSharp();
TryNull();


class MinhaClasse()
{
    public void Meumetodo()
    {
        
    }
}