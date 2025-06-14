using gatorabs.HttpAndLinQ_2.Models;
using System.Text.Json;

using (HttpClient client = new())
{
    var response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
    var movies = JsonSerializer.Deserialize<List<Movie>>(response);

    var orderedMovies = movies.Where(o => Int32.Parse(o.Year) >= 2000);
    foreach (Movie movie in orderedMovies)
    {
        movie.ShowMovieDetail();
    }

}