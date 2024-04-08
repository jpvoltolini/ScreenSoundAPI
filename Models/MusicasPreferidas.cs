using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSoundAPI.Models
{
    internal class MusicasPreferidas
    {
        public string? Nome { get; set; }

        List<Musica> ListaDeMusicasPreferidas;
        
        public MusicasPreferidas(string nome) 
        {
            Nome = nome;
            ListaDeMusicasPreferidas = new List<Musica>();  
        }

        public void AddMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasPreferidas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"\nEssas são as musicas favoritas de: {Nome}\n\n");

            foreach (var musica in ListaDeMusicasPreferidas)
            {
                Console.WriteLine($"{musica.Nome}  -  {musica.Artista}");
            }
        }

        public void GerarMusicasJson()
        {
            string json = JsonSerializer.Serialize(new 
            {
                nome = Nome,
                musicas = ListaDeMusicasPreferidas
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine($"\nArquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}
