using System.Text.Json;
using ScreebSoundComAPIExterna.Modelos;
using ScreebSoundComAPIExterna.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas); 
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");  
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló"); 

        var musicasPreferidasDoPedro = new MusicasPreferidas("Pedro");
        musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[377]);
        musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[1467]); 


        musicasPreferidasDoPedro.ExibirMusicasFavoritas(); 

        musicasPreferidasDoPedro.GerarArquivoJson(); 
    }
    catch(Exception ex)
    {
        System.Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}