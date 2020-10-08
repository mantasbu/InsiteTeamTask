using System.Collections.Generic;
using InsiteTeamTask.Models;
using InsiteTeamTask.Repositories.SeasonRepo;
using Microsoft.AspNetCore.Mvc;

namespace InsiteTeamTask.Controllers
{
    [Route("api/[controller]")]
    public class SeasonController : Controller
    {
        ISeasonRepository _seasonRepository;

        public SeasonController(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Season>> Get(int id)
        {
            if (id < 1)
            {
                return BadRequest("id is required");
            }
            List<Season> seasons = _seasonRepository.GetSeasonsByEventId(id);
            if (seasons.Count > 0)
            {
                return Ok(seasons);
            }
            else
            {
                return NotFound("No records found");
            }
        }
    }
}
