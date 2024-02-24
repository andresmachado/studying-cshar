using System.Globalization;

namespace OtherTasksNamespace
{
    public static class Currency
    {
        public static void ExampleCurrency()
        {
            Console.WriteLine("\n----------------- Currency -----------------");
            decimal value = 10150.5m;
            Console.WriteLine(value.ToString("C"));
            Console.WriteLine(value.ToString("F", new CultureInfo("pt-BR")));
            Console.WriteLine(value.ToString("N", new CultureInfo("pt-BR")));
            Console.WriteLine(value.ToString("P", new CultureInfo("pt-BR")));
            Console.WriteLine(value.ToString("G", new CultureInfo("pt-BR")));
            Console.WriteLine(value.ToString("C", new CultureInfo("en-US")));

            Console.WriteLine("\n----------------- Currency Precision -----------------");
            decimal value2 = 10150.5m;
            Console.WriteLine(Math.Round(value2).ToString("C"));
            Console.WriteLine(Math.Ceiling(value2).ToString("F", new CultureInfo("pt-BR")));
            Console.WriteLine(Math.Floor(value2).ToString("N", new CultureInfo("pt-BR")));
        }
    }
}