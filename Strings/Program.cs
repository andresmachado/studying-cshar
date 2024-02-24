/*
    Strings in C# is a sequence of characters. It is an object of type System.String.
    Strings are immutable, meaning that they cannot be changed after they are created.
    Any modification to a string will result in a new string object.
    The 'string' keyword is an alias for System.String.
    The string class provides a large number of methods for comparing, searching, and modifying strings.
    Since it's a sequence of characters, you can access the characters by index. Like an array. ie.: myString[0]
*/

using System.Text;

static void AboutGuid()
{
    var id = Guid.NewGuid(); // Create a new GUID
    var sub = id.ToString().Substring(0, 8);  // Get the first 8 characters
    Console.WriteLine(id);
    Console.WriteLine(sub);
}

static void AboutInterpolation()
{
    var name = "John";
    var age = 30;
    Console.WriteLine($"Name: {name}, Age: {age}");
    var formatted = string.Format("Name: {0}, Age: {1}", name, age); // Old way
    Console.WriteLine(formatted);

    var multilineString = $@"Name: {name}
    Age: {age}";  // ignores special characters like \n

    Console.WriteLine(multilineString);
}

static void CompareStrings()
{
    var name = "John";
    var name2 = "john";
    var text = "multiple words separated by spaces";

    Console.WriteLine(name.CompareTo(name2)); // Returns 1 when it's False, 0 when it's True
    Console.WriteLine(text.Contains("words")); // Returns a boolean
    Console.WriteLine(text.Contains("Banana", StringComparison.OrdinalIgnoreCase)); // Ignores case, returns a boolean
}

static void AboutString()
{
    var text = "Hello World";
    Console.WriteLine(text.StartsWith("Hello", StringComparison.OrdinalIgnoreCase)); // Returns a boolean
    Console.WriteLine(text.EndsWith("World")); // Returns a boolean
    Console.WriteLine(text.Length); // Returns the length of the string
    Console.WriteLine(text.IndexOf("World")); // Returns the index of the first occurrence of the word
    Console.WriteLine(text.LastIndexOf("o")); // Returns the index of the last occurrence of the character
    Console.WriteLine(text.Substring(6)); // Returns a substring from the index to the end
    Console.WriteLine(text.Substring(6, 3)); // Returns a substring from the index with the length
    Console.WriteLine(text.Replace("World", "C#")); // Replaces the first occurrence of the word
    Console.WriteLine(text.Replace("o", "0")); // Replaces all occurrences of the character
    Console.WriteLine(text.ToUpper()); // Returns the string in uppercase
    Console.WriteLine(text.ToLower()); // Returns the string in lowercase
    Console.WriteLine(text.Trim()); // Removes leading and trailing white spaces
    Console.WriteLine(text.TrimStart()); // Removes leading white spaces
    Console.WriteLine(text.TrimEnd()); // Removes trailing white spaces
    Console.WriteLine(text.PadLeft(20)); // Pads the string with spaces to the right
    Console.WriteLine(text.PadRight(20)); // Pads the string with spaces to the left
    Console.WriteLine(text.PadLeft(20, '*')); // Pads the string with a character to the right
    Console.WriteLine(text.PadRight(20, '*')); // Pads the string with a character to the left
    Console.WriteLine(text.Split(' ')); // Splits the string into an array of strings
    Console.WriteLine(text.Split(' ')[0]); // Access the first element of the array
    Console.WriteLine(text.Equals("Hello World")); // Returns a boolean

    var words = new string[] { "Hello", "World", "Again", "C#"};
    var newString = string.Join(" ", words); // Joins the array of strings into a single string
    Console.WriteLine(newString);

    text.Insert(5, "C#"); // Inserts a string at the specified index, returns a new string and doesn't modify the original
    Console.WriteLine(text);

    var spplited = newString.Split(' '); // Splits the string into an array of strings
    for (int i = 0; i < spplited.Length; i++)
    {
        Console.WriteLine(spplited[i]);
    }
}

static void StringBuilderExample()
{
    /*
        The StringBuilder class is used to create mutable (read-write) string objects.
        It's more efficient than using the string class when you need to modify the string multiple times.
        If you need to build a string from multiple strings, you should use the StringBuilder class.
        If you need to use the content of the StringBuilder as a string, you can use the ToString method,
        Console.WriteLine converts it automatically.
    */

    var sb = new StringBuilder();
    sb.Append("Hello");
    sb.Append(" ");
    sb.Append("World");
    Console.WriteLine(sb.ToString());
    sb.Insert(5, "C#");
    Console.WriteLine(sb.ToString());
    sb.Remove(5, 2);
    Console.WriteLine(sb.ToString());
    sb.Replace("World", "C#");
    Console.WriteLine(sb.ToString());
}