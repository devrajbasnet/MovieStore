using System.ComponentModel.DataAnnotations;

namespace MovieStore.Data
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        
        public string? GenreName {  get; set; }
    }
}
