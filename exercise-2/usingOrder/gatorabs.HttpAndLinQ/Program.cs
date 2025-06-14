using gatorabs.HttpAndLinQ.Models;
using System.Text.Json;

using (HttpClient client = new())
{
    var response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(response);
    var musicas = JsonSerializer.Deserialize<List<Music>>(response);
    var musicasOrdem = musicas.OrderBy(m => m.Artist);
    var musicasOrdemGenre = musicas.OrderBy(m => m.Artist == "Eminem");
    musicasOrdem.ToList<Music>();

    foreach (Music musica in musicasOrdemGenre)
    {
        musica.ShowMusicDetail();
        Console.WriteLine("");
    }
}