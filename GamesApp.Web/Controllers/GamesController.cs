using GamesApp.Web.Models;
using GamesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace GamesApp.Web.Controllers
{
    // Using a primary constructor that injects the GameService instance
    public class GamesController(GameService gameService) : Controller
    {
        [HttpGet("")]
        public IActionResult Index() => View(gameService.GetAllGames());


        [HttpGet("/AddGame")]
        public IActionResult AddGame() => View();


        [HttpPost("/AddGame")]
        public IActionResult AddGame(Game game)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            // Add the game to the list of games if Model State is valid
            gameService.AddGame(game);

            // Redirect to Index after the game is added
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/ViewGame{id}")]
        public IActionResult ViewGame(int id) => View(gameService.GetGameById(id));
    }
}
