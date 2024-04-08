using ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try 
    { 
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        //musicas[1].ExibirDetalhesMusica();

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas); /// filtra os generos
        //LinqOrder.ExibirArtistasEmOrdem(musicas);          /// ordena os artistas
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "blues"); /// Filtrar Artistas Por Genero Musical
        //LinqFilter.FiltrarMusicasDeArtista(musicas, "U2");
        LinqFilter.FiltrarTonalidade(musicas);

        //var minhasMusicasPreferidas = new MusicasPreferidas("JP");
        //minhasMusicasPreferidas.AddMusicasFavoritas(musicas[13]);
        //minhasMusicasPreferidas.AddMusicasFavoritas(musicas[62]);
        //minhasMusicasPreferidas.AddMusicasFavoritas(musicas[126]);
        //minhasMusicasPreferidas.AddMusicasFavoritas(musicas[66]);
        //minhasMusicasPreferidas.AddMusicasFavoritas(musicas[1116]);

        //minhasMusicasPreferidas.ExibirMusicasFavoritas();
        //minhasMusicasPreferidas.GerarMusicasJson();
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }
}