using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;
using TestApi.Services;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GameController : ControllerBase
    {
        private readonly IDatabaseService databaseService;

        public GameController(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        [HttpGet]
        public ActionResult GetGames()
        {
            var games = this.databaseService.GetGames();
            return Ok(games);
        }

        [HttpPost]
        public ActionResult CreateGame(Game game)
        {
            this.databaseService.AddGame(game);
            return Created();
        }

    }
}
