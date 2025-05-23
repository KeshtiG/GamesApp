using System.ComponentModel.DataAnnotations;

public class AddGameVM
{
    [Required(ErrorMessage = "You need to enter a game name.")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "You need to enter a game developer.")]
    public required string Developer { get; set; }

    [Required(ErrorMessage = "You need to enter a game genre.")]
    public required string Genre { get; set; }

    [Display(Name = "Release year")]
    [Required(ErrorMessage = "You need to enter a release year.")]
    public required int Year { get; set; }

    [Required(ErrorMessage = "You need to enter a game description.")]
    public required string Description { get; set; }

    [Display(Name = "Image URL")]
    public string? ImageUrl { get; set; }
}