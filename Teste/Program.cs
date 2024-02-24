using System;

namespace Test // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // IfConditional(args);
            // Convertion(args);

            // string operation = "/";
            // SwitchConditional(operation);

            // int counter = 10;
            // RepetitionFor(1, counter);
            // RepetitionWhile(1, counter);
            // RepetitionDoWhile(1, counter);

            // string nome = MetodoNaoVoid("Andre", "Machado");
            // Console.WriteLine($"Retorno: {nome}");

            // string nomeIdade = MetodoNaoVoid("Andre", "Machado", 36);
            // Console.WriteLine($"Retorno: {nomeIdade}");

            // ReferenceTypes(args);
            // ValueTypes(args);

            // // ---- Structs ----

            // StructExamples(args);

            AverageRate();
            ShowCSharp();
            ShowSelectedPosition();
        }
        static string MetodoNaoVoid(string nome, string sobrenome, int idade = 0)
        {
            Console.WriteLine("\nMetodoNaoVoid");
            Console.WriteLine($"Nome: {nome} {sobrenome}");
            return nome + " " + sobrenome + " " + idade + " anos";
        }
        /*
        O laço DO WHILE demanda apenas 2 parametros para ser executado, exemplo:
        atribuição de valor (var i);
        condição de parada (i <= 5).

        É necessário incrementar a variável de controle dentro do bloco de código, caso contrário,
        o laço será infinito. O laço DO WHILE executa o bloco de código pelo menos uma vez, mesmo que a condição de parada seja falsa.
        */
        static void RepetitionDoWhile(int initializer, int counter)
        {
            Console.WriteLine("\nRepetition Do-While");
            int i = initializer;
            do
            {
                Console.WriteLine($"contador i = {i}");
                i++;
            } while (i <= counter);
        }

        /*
        O laço WHILE demanda apenas 1 parametro para ser executado, exemplo:
        atribuição de valor (var i);
        condição de parada (i <= 5).

        É necessário incrementar a variável de controle dentro do bloco de código, caso contrário, 
        o laço será infinito.
        */
        static void RepetitionWhile(int initializer, int counter)
        {
            Console.WriteLine("\nRepetition While");
            int i = initializer;
            while (i <= counter)
            {
                Console.WriteLine($"contador i = {i}");
                i++;
            }
        }

        /*
        O laço FOR demanda 3 parametros para ser executado, exemplo:
        atribuição de valor (var i);
        a variável de controle (i <= 5);
        condição de parada e incremento (i++).
        */
        static void RepetitionFor(int initializer, int counter)
        {
            Console.WriteLine("\nRepetition For");
            for (int i = initializer; i <= counter; i++)
            {
                Console.WriteLine($"contador i = {i}");
            }
        }
        static void SwitchConditional(string operation)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("\nSwitch Conditional");
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Operation is {operation}, result: {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"Operation is {operation}, result: {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"Operation is {operation}, result: {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"Operation is {operation}, result: {a / b}");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
        static void Convertion(string[] args)
        {
            int integer = 100;
            float real = 12.5f;
            Console.WriteLine("Real: " + real);
            // real = integer; // Implicit conversion
            // integer = (int)real; // Explicit conversion
            integer = Convert.ToInt32(real);
            Console.WriteLine("Integer: " + integer);

            string intToString = real.ToString();
            Console.WriteLine("Integer to string: " + intToString);
            Console.WriteLine(Convert.ToBoolean(255));
            Console.WriteLine(Convert.ToBoolean(0));
        }
        static void IfConditional(string[] args)
        {
            int a = 10;
            int b = 20;
            if (a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if (a < b)
            {
                Console.WriteLine("a is less than b");
            }
            else
            {
                Console.WriteLine("a is equal to b");
            }
        }
        static void ValueTypes(string[] args)
        {
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine("a: " + a); // 10
            Console.WriteLine("b: " + b); // 20
        }
        static void ReferenceTypes(string[] args)
        {
            int[] arr = new int[2];
            arr[0] = 10;

            int[] brr = arr; // Reference copy
            brr[0] = 20; // Changes arr[0] as well

            Console.WriteLine("a: " + arr[0]); // 20
            Console.WriteLine("b: " + brr[0]); // 20
        }
        static void StructExamples(string[] args)
        {
            double dolarRate = 5.5f;
            Product product1 = new Product
            {
                Id = 1,
                Name = "Product 1",
                Price = 10.5,
                DeliveryWeekDay = EWeek.Friday
            };

            Product mouse = new Product();
            mouse.Id = 2;
            mouse.Name = "Mouse";
            mouse.Price = 5.5;
            mouse.DeliveryWeekDay = EWeek.Tuesday;

            Product keyboard = new Product(
                id: 3,
                name: "Keyboard",
                price: 10.5,
                deliveryDay: EWeek.Monday
            );

            Console.WriteLine("\n" + product1.Name);
            Console.WriteLine(product1.PriceInDolar(5.5f));
            Console.WriteLine("Weekday " + (int)product1.DeliveryWeekDay);

            Console.WriteLine("\n" + mouse.Name);
            Console.WriteLine(mouse.PriceInDolar(dolarRate));
            Console.WriteLine(mouse.DeliveryWeekDay); // Direct reference to enum to get the key name
            Console.WriteLine("Weekday " + (int)mouse.DeliveryWeekDay); // Explicit cast to int to get the enum value


            Console.WriteLine("\n" + keyboard.Name);
            Console.WriteLine(keyboard.PriceInDolar(dolarRate));
            Console.WriteLine("Weekday " + (int)keyboard.DeliveryWeekDay);
        }

        static void AverageRate()
        {
            var averageGrade = 9;

            if (averageGrade >= 5)
            {
                Console.WriteLine("Nota suficiente para aprovação!");
            }
        }

        static void ShowCSharp()
        {
            string[] languageArray = { "C#", "Java", "Python", "JavaScript" };
            Console.WriteLine(languageArray[0]);
        }

        static void ShowSelectedPosition()
        {
            string[] languageArray = { "C#", "Java", "Python", "JavaScript" };
            int selection = int.Parse(Console.ReadLine()!);
            Console.WriteLine(languageArray[selection]);
        }

    }
    enum EWeek
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    }
    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        public EWeek DeliveryWeekDay;
        public Product(int id, string name, double price, EWeek deliveryDay)
        {
            Id = id;
            Name = name;
            Price = price;
            DeliveryWeekDay = deliveryDay;
        }
        public double PriceInDolar(double dolarRate)
        {
            return Price * dolarRate;
        }
    }
}