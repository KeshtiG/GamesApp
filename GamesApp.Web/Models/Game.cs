using System.ComponentModel.DataAnnotations;

namespace GamesApp.Web.Models;

public class Game
{
    public int Id { get; set; }

    [Required(ErrorMessage = "You need to enter a game name.")]
    public string? Name { get; set; }
    
    
    [Required(ErrorMessage = "You need to enter a game developer.")]
    public string? Developer { get; set; }


    [Required(ErrorMessage = "You need to enter a game description.")]
    public string? Description { get; set; }


    [Required(ErrorMessage = "You need to enter a game genre.")]
    public string? Genre { get; set; }

    [Display(Name = "Release year")]
    [Required(ErrorMessage = "You need to enter a release year.")]
    public int Year { get; set; }

    [Display(Name = "Image URL")]
    public string? ImageUrl { get; set; }
}
