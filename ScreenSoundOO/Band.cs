class Band
{
    public Band(string name)
    {
        Name = name;
    }
    private List<Album> albums = new List<Album>();
    public string Name { get; }
    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"{Name} discography: ");
        Console.WriteLine("Name\t\t\tLength (in seconds)");
        foreach (var album in albums)
        {
            
            Console.WriteLine($"{album.Name}\t{album.Length}");
        }
    }
}