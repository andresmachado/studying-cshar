using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(IEnumerable<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas
            .Select(generos => generos.Genero)
            .Distinct()
            .ToList();
        foreach (var genero in todosOsGenerosMusicais) Console.WriteLine($"- {genero}");
    }

    public static void FiltrarArtistasPorGeneroMusical(IEnumerable<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas
            .Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine($"Exibindo artistas por genero musica >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical) Console.WriteLine($"- {artista}");
    }

    public static void FiltrarMusicasDeUmArtista(IEnumerable<Musica> musicas, string artista)
    {
        var musicasDeUmArtista = musicas
            .Where(musica => musica.Artista!.Equals(artista))
            .ToList();
        Console.WriteLine(artista);
        foreach (var musica in musicasDeUmArtista) Console.WriteLine($"- {musica.Nome}");
    }

    public static void FiltrarMusicasPorAno(IEnumerable<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas
            .Where(musica => musica.Ano.Equals(ano))
            .OrderBy(musica => musica.Nome)
            .Select(musica => musica.Nome)
            .Distinct()
            .ToList();
        Console.WriteLine($"Musicas do ano {ano}");
        foreach (var musica in musicasDoAno) Console.WriteLine($"- {musica}");
    }
}