using GamesApp.Web.Models;
using GamesApp.Web.Services;
using GamesApp.Web.Views.Games;
using Microsoft.AspNetCore.Mvc;

namespace GamesApp.Web.Controllers
{
    // Using a primary constructor that injects the GameService instance
    public class GamesController(GameService gameService) : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            var model = gameService.GetAllGames();
            var viewModel = new IndexVM()
            {
                GameItems = model
                    .Select(o => new IndexVM.GameItemVM
                    {
                        Id = o.Id,
                        Name = o.Name ?? string.Empty,
                        ImageUrl = o.ImageUrl ?? string.Empty,
                    })
                    .ToArray()
            };
            return View(viewModel);
        }


        [HttpGet("/AddGame")]
        public IActionResult AddGame() => View();


        [HttpPost("/AddGame")]
        public IActionResult AddGame(AddGameVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var model = new Game
            {
                Name = viewModel.Name,
                Developer = viewModel.Developer,
                Genre = viewModel.Genre,
                Year = viewModel.Year,
                ImageUrl = viewModel.ImageUrl,
                Description = viewModel.Description,
            };

            // Add the game to the list of games if Model State is valid
            gameService.AddGame(model);

            // Redirect to Index after the game is added
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/ViewGame{id}")]
        public IActionResult ViewGame(int id)
        {
            var model = gameService.GetGameById(id);
            var viewModel = new ViewGameVM()
            {
                Name = model.Name ?? string.Empty,
                Developer = model.Developer,
                Genre = model.Genre,
                Year = model.Year,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
            };

            return View(viewModel);
        }
    }
}
