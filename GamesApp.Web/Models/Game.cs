using System.ComponentModel.DataAnnotations;

namespace GamesApp.Web.Models;

public class Game
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Developer { get; set; } = null!;
    public string Genre { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Year { get; set; }
    public string? ImageUrl { get; set; }
}
