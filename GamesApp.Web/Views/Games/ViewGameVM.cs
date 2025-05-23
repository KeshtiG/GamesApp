namespace GamesApp.Web.Views.Games;

public class ViewGameVM
{
    public required string Name { get; set; }
    public required string? Developer { get; set; }
    public required string? Genre { get; set; }
    public required string? Description { get; set; }
    public required int Year { get; set; }
    public required string? ImageUrl { get; set; }
}
