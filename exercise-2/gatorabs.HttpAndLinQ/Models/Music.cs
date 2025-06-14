using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gatorabs.HttpAndLinQ.Models
{
    public class Music
    {

        [JsonPropertyName("artist")]
        public string Artist { get; set; }

        [JsonPropertyName("song")]
        public string Song { get; set; }

        [JsonPropertyName("genre")]
        public string Genre { get; set; }

        public void ShowMusicDetail()
        {
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Artist: {Song}");
            Console.WriteLine($"Artist: {Genre}");
            Console.WriteLine("");
        }
    }
}
