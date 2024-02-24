namespace OtherTasksNamespace
{
    public class Exceptions
    {
        public static void ExampleExceptions()
        {
            Console.WriteLine("\n----------------Exceptions----------------\n");
            try
            {
                int a = 10;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
            }

            // Raising custom exeptions
            try
            {
                throw new MyException("This is a custom exception");
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Raise Regular Exception {e.Message}");
            }
            finally
            {
                // The finally block will always be executed, regardless of whether an exception was thrown or not.
                Console.WriteLine("This will always be executed");
            }
        }

        public class MyException : Exception { 
            public MyException(string message) : base(message) { }
        }
    }
}