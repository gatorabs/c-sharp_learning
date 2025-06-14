using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gatorabs.HttpAndLinQ_2.Models
{
    public class Movie
    {

        [JsonPropertyName("rank")]
        public string Rank { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }


        public void ShowMovieDetail()
        {
            Console.WriteLine($"Movie: {Title}");
            Console.WriteLine($"Rank: {Rank}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Image: {Image}");
            Console.WriteLine("");
        }
    }
}
