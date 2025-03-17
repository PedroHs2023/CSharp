using System.Runtime.ConstrainedExecution;
using ScreebSoundComAPIExterna.Modelos;

namespace ScreebSoundComAPIExterna.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todoOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todoOsGenerosMusicais)
        {
            System.Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        System.Console.WriteLine($"Exibindo os artistas por genero musical >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            System.Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista));
        System.Console.WriteLine("nomeDoArtista");
        foreach (var musica in musicasDoArtista)
        {
            System.Console.WriteLine($"-{musica.Nome}");
        }

    }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();
        System.Console.WriteLine("Musicas em C#: ");
        foreach (var musica in musicasEmCSharp)
        {
            System.Console.WriteLine($"- {musica}");
        }

    }
}
