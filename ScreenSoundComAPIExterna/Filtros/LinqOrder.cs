using ScreebSoundComAPIExterna.Modelos;

namespace ScreebSoundComAPIExterna.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        System.Console.WriteLine("Lista de Artistas ordenados:");
        foreach (var artista in artistasOrdenados)
        {
            System.Console.WriteLine($"- {artista}");
        }
    }
}