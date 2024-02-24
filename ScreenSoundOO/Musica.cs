// Atributos não definem métodos de controle
// Propriedades definem métodos de controle
class Track
{
    public Track(string name, Band artist)
    {
        Artist = artist;
        Name = name;
    }
    public string Name { get; }
    public Band Artist { get; }
    public int Length { get; set; }
    public bool Available { get; set; }

    public string ShortDescription => $"{Name} is a music from {Artist}";

    public void TechnicalInfo()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Length}");
        if (Available)
        {
            Console.WriteLine("Available");
        }
        else
        {
            Console.WriteLine("Not available");
        }
    }
}