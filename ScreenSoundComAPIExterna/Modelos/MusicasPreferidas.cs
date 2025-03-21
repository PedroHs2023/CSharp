namespace ScreebSoundComAPIExterna.Modelos;
using System.Text.Json;


internal class MusicasPreferidas
{
    public string?  Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas;

    public MusicasPreferidas(string nome){
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        System.Console.WriteLine($"Essas sao as musicas favoritas -> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
             System.Console.WriteLine($" - {musica.Nome} de {musica.Artista}");           
        }
        System.Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas,
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        System.Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");

    }
}