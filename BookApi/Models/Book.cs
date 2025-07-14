using System.ComponentModel.DataAnnotations;

namespace BookApi.Models;
public class Book
{
    public int Id { get; set; }

    [Required]
    [StringLength(200)]
    public string Title { get; set; }

    [Required]
    [StringLength(100)]
    public string Author { get; set; }

    [Range(0, 2100)]
    public int PublishedYear { get; set; }

    [Required]
    [StringLength(50)]
    public string Language { get; set; }

    [Required]
    [StringLength(50)]
    public string Genre { get; set; }
}