using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Models
{
    internal class Musica
    {
        public string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
     // isso fas parte do desafio 1 do curto.
     // Essa lista vai funcionar para a posição indicada por "key" (0, 1, 2..)
     // onde cada numero indica uma posição na tonalidade.


        [JsonPropertyName("song")]
        public string Nome { get; set; }

        [JsonPropertyName("artist")]
        public string Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string Genero { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string Tonalidade {
            get
            {
                return tonalidades[Key];
            }
        }

        public void ExibirDetalhesMusica() // metodo deve ser chamado em variavel
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Musica: {Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");
        }

    }
}
