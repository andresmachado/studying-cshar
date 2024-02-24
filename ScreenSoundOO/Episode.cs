class Episode
{
    private List<string> guests = new List<string>();
    public Episode(int number, string title, int length)
    {
        Number = number;
        Title = title;
        Length = length;
    }
    public int Number { get; }
    public string Title { get; }
    public int Length { get; }
    public string Synopsis => $"Episode: {Number}\nTitle: {Title}\nLength: {Length} min\nGuests: {string.Join(", ", guests)}";

    public void AddGuests(string guest)
    {
        guests.Add(guest);
    }
}