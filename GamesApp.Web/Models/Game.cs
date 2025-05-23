using System.ComponentModel.DataAnnotations;

namespace GamesApp.Web.Models;

public class Game
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Developer { get; set; }
    public string? Genre { get; set; }
    public string? Description { get; set; }
    public int Year { get; set; }
    public string? ImageUrl { get; set; }
}
