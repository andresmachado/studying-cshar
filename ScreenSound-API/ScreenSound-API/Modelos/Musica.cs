using System.Text.Json.Serialization;

namespace ScreenSound_API.Modelos;

internal class Musica
{
    [JsonPropertyName("year")] public string? AnoString { get; set; }
    public int Ano => int.Parse(AnoString!);

    [JsonPropertyName("song")] // This is called annotation
    public string? Nome { get; set; }

    [JsonPropertyName("artist")] public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")] public int Duracao { get; set; }

    [JsonPropertyName("genre")] public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Duracao em segundos: {Duracao / 1000}");
        Console.WriteLine($"Genero musical: {Genero}");
    }
}