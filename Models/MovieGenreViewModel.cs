using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication_L2V2.Models
{
    public class MovieGenreViewModel
    {
        public List<Movies>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
