using GamesApp.Web.Models;
using GamesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace GamesApp.Web.Controllers
{
    public class GamesController : Controller
    {
        static GameService gameService = new GameService();

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

            gameService.AddGame(game);
            return RedirectToAction(nameof(Index));
        }

    }
}
