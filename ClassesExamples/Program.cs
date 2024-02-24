Car car = new Car();
car.Brand = "Ferrari";
car.Model = "LaFerrari";
car.Year = 2024;
car.Color = "Red";
car.Price = 1000000;
car.Accelerate();
car.Brake();
car.Honk();

Product product = new Product();
product.Name = "Laptop";
product.Price = 2000;
product.Stock = 10;
product.Brand = "Dell";
Console.WriteLine(product.LongDescription);

Console.WriteLine("Product 2");
Product product2 = new Product();
product2.Name = "Smartphone";
product2.Price = 0;
product2.Stock = 0;

Console.WriteLine("\nLambda Function");

static int Sum (int a, int b) => a + b;
Console.WriteLine(Sum(5,5));


class Product
{
    private int stock;
    private decimal price;
    public string? Name { get; set; }
    public decimal Price { 
        get => price;
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Valor inválido, insira um valor maior que 0");
            }
            else
            {
                price = value;
            }
        }
    }
    public int Stock 
    { 
        get => stock;
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Valor inválido, insira um valor maior que 0");
            }
            else
            {
                stock = value;
            }
        }
    }
    public string? Brand { get; set; }
    public string LongDescription => $"The product {Name} from the brand {Brand} costs {Price} and has {Stock} in stock.";
}

class Car
{
    private int year;
    public string Brand;
    public string Model;
    public int Year
    {
        get => year;
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }
            else
            {
                year = value;
            }
        }
    }
    public string Color;
    public decimal Price;

    public void Accelerate()
    {
        Console.WriteLine($"The {Brand} {Model} is accelerating!");
    }

    public void Brake()
    {
        Console.WriteLine($"The {Brand} {Model} is braking!");
    }

    public void Honk()
    {
        Console.WriteLine($"The {Brand} {Model} is honking!");
    }
}
