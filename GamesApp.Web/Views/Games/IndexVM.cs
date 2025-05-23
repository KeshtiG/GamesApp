namespace GamesApp.Web.Views.Games;

public class IndexVM
{
    public required GameItemVM[] GameItems {  get; set; }

    public class GameItemVM
    {
        public required int Id { get; set; }
        public required string Name { get; set; } 
        public required string ImageUrl { get; set; }
    }
}
