class Podcast
{
    public Podcast(string host, string name)
    {
        Host = host;
        Name = name;
    }
    public string Host { get; }
    public string Name { get; }
    public string TotalEpisodes => $"Total episodes: {episodes.Count}";
    private List<Episode> episodes = new List<Episode>();

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void Description()
    {
        Console.WriteLine($"{Name} by {Host}");
        Console.Write("\nEpisodes: ");
        foreach (var epi in episodes.OrderBy(e => e.Number))
        {
            Console.WriteLine($"\n{epi.Synopsis}");
        }
    }
}