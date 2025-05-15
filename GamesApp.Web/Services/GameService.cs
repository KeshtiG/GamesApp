using GamesApp.Web.Models;

namespace GamesApp.Web.Services
{
    public class GameService
    {
        private List<Game> games = [
            new Game {
                Id = 1,
                Name = "Space Marine 2",
                Developer = "Saber Interactive",
                Genre = "Third-person shooter",
                Year = 2024,
                Description = "Space Marine 2 is a third-person action shooter set in the grim Warhammer 40,000 universe. You play as an Ultramarine, a superhuman soldier, battling endless swarms of Tyranids in brutal melee and ranged combat. As a sequel to the 2011 cult hit Space Marine, the game delivers intense, cinematic battles and a dark, war-torn sci-fi atmosphere.",
                ImageUrl = "/Images/sm2-header.jpg"
            },
            new Game {
                Id = 2,
                Name = "World War Z",
                Developer = "Saber Interactive",
                Genre = "Third-person shooter",
                Year = 2019,
                Description = "World War Z is a fast-paced third-person shooter inspired by the movie of the same name. Players team up to fight massive swarms of zombies across various global locations. With intense co-op action, class-based characters, and strategic combat, it delivers chaotic fun against overwhelming odds.",
                ImageUrl = "/Images/wwz-header.jpg"
            },
            new Game {
                Id = 3,
                Name = "Hogwarts Legacy",
                Developer = "Avalanche Software",
                Genre = "Open-world RPG",
                Year = 2023,
                Description = "Hogwarts Legacy is an immersive, open-world action RPG set in the 1800s wizarding world. Players assume the role of a student at Hogwarts School of Witchcraft and Wizardry who holds the key to an ancient secret threatening to tear the wizarding world apart. Throughout the game, players can explore iconic and new locations, learn to cast spells, brew potions, tame magical beasts, and personalize their character to become the witch or wizard they aspire to be.",
                ImageUrl = "/Images/hogwarts-header.jpg"
            },
            new Game {
                Id = 4,
                Name = "Red Dead Redemption 2",
                Developer = "Rockstar Games",
                Genre = "Open-world action-adventure",
                Year = 2018,
                Description = "Red Dead Redemption 2 is an open-world action-adventure game set in 1899, following Arthur Morgan, a member of the Van der Linde gang, as he navigates the decline of the Wild West. Players engage in a richly detailed world, experiencing a deep narrative, dynamic weather, wildlife, and immersive gameplay. The game offers both single-player and multiplayer modes, with the latter known as Red Dead Online.",
                ImageUrl = "/Images/rdr2-header.jpg"
            },
            new Game {
                Id = 5,
                Name = "The Forest",
                Developer = "Endnight Games",
                Genre = "Survival horror",
                Year = 2018,
                Description = "The Forest is a first-person survival horror game where you play as the lone survivor of a plane crash, stranded in a mysterious forest. To survive, you must build shelter, scavenge for resources, and fend off a tribe of cannibalistic mutants. With its eerie atmosphere, crafting system, and open-ended gameplay, The Forest offers a tense and immersive survival experience, especially when played in co-op mode.",
                ImageUrl = "/Images/forest-header.jpg"
            },
            new Game {
                Id = 6,
                Name = "Friday the 13th: The Game",
                Developer = "IllFonic",
                Genre = "Asymmetrical multiplayer",
                Year = 2017,
                Description = "Friday the 13th: The Game is an asymmetrical multiplayer horror game where players take on the role of either Jason Voorhees or one of seven camp counselors at Camp Crystal Lake. As Jason, the objective is to hunt down and eliminate all counselors using a variety of brutal methods. As a counselor, players must work together to escape, survive, or even attempt to defeat Jason. The game features iconic locations and characters from the Friday the 13th franchise, offering a tense and thrilling experience.",
                ImageUrl = "/Images/friday-header.jpg"
            }
        ];

        public void AddGame(Game game)
        {
            game.Id = games.Count == 0 ? 1 : games.Max(d => d.Id) + 1;

            if (string.IsNullOrWhiteSpace(game.ImageUrl))
            {
                game.ImageUrl = "/Images/placeholder-header.jpg";
            }

            games.Add(game);
        }

        public Game[] GetAllGames() => games.OrderBy(d => d.Name).ToArray();

        public Game GetGameById(int id) => games.Single(d => d.Id == id);

    }
}
