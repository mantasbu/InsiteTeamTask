using System.Collections.Generic;
using InsiteTeamTask.Models;
using InsiteTeamTask.Repositories.GameRepo;
using Microsoft.AspNetCore.Mvc;

namespace InsiteTeamTask.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Game>> Get(int id)
        {
            if (id < 1)
            {
                return BadRequest("id is required");
            }

            Game game = _gameRepository.Get(id);
            if (game != null)
            {
                return Ok(game);
            }
            else
            {
                return NotFound("No records found");
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Game>> Get()
        {
            List<Game> games = _gameRepository.GetAll();
            if (games.Count > 0)
            {
                return Ok(games);
            }
            else
            {
                return NotFound("No records found");
            }
        }
    }
}
