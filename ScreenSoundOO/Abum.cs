class Album
{
    public Album(string name, AlbumGenre genre)
    {
        Name = name;
        Genre = genre;
    }
    private List<Track> tracks = new List<Track>();
    public string Name { get; }
    public int Length => tracks.Sum(track => track.Length);

    public AlbumGenre Genre { get; }
    public void AddTrack(Track track)
    {
        tracks.Add(track);
    }

    public void ShowTracks()
    {
        Console.WriteLine($"{Name} album track list: ");
        foreach (var track in tracks)
        {
            Console.WriteLine(track.Name);
        }

        Console.WriteLine($"Album full length: {Length} seconds");
    }
}