using ScreenSoundAPI.Models;

namespace ScreenSoundAPI.Filter
{
    internal class LinqOrder
    {
        public static void ExibirArtistasEmOrdem(List<Musica> musicas)
        {
            var artistasEmOrdem = musicas.OrderBy(musica => musica.Artista).Select(musica =>
            musica.Artista).Distinct().ToList();
            // Seleciona todos os artista em ordem alfabetica, distintos, para uma lista.

            Console.WriteLine($"Lista de artistas ordenados: ");

            foreach (var artista in artistasEmOrdem)
            {
                Console.WriteLine($" - {artista}");
            }

        }
    }
}
