using ScreenSoundAPI.Models;

namespace ScreenSoundAPI.Filtros
{
    internal class LinqFilter
    {

        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGernerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            // Seleciona todos os Generos musicais, distintos, para uma lista.

            foreach (var genero in todosOsGernerosMusicais)
            {
                Console.WriteLine($" - {genero}");
            }
        }


        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).
            OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
            // Se usa o Where, para pegar um conjunto

            Console.WriteLine($"\nExibindo artistas por genero musical: ------> {genero.ToUpper()}\n\n");
            //          Filtra os artistas que possuem o mesmo genero, em ordem alfabetica, selecionando os artistas distindos


            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($" - {artista} - {genero.ToUpper()}");
            }
        }


        public static void FiltrarMusicasDeArtista(List<Musica> musicas, string nomeDoArtista)
        {
            var musicasDeArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();

            Console.WriteLine($"\nExibindo musicas do artista: {nomeDoArtista}\n\n");

            foreach (var musica in musicasDeArtista)
            {
                Console.WriteLine($" {nomeDoArtista} - {musica.Nome}");
            }
        }

        public static void FiltrarTonalidade(List<Musica> musicas)
        {
            var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#"))
                .Select(musica => musica.Nome).ToList();

            Console.WriteLine($"\n Musicas do tom: C# \n\n");

            foreach (var musica in musicasEmCSharp)
            {
                Console.WriteLine($" - {musica}\n");
            }

        }
    }
}
