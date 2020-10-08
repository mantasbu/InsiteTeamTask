using System.Collections.Generic;
using InsiteTeamTask.Models;
using InsiteTeamTask.Repositories.AttendanceRepo;
using Microsoft.AspNetCore.Mvc;

namespace InsiteTeamTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private IAttendanceRepository _attendanceRepository;

        public AttendanceController(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        [HttpGet("product/{productId}")]
        public ActionResult<IEnumerable<Attendance>> GetAttendanceByProductId(string productId)
        {
            if (productId == null)
            {
                return BadRequest("productId is required");
            }

            var attendance = _attendanceRepository.GetAttendanceListByProductId(productId);

            if (attendance.Count > 0)
            {
                return Ok(attendance);
            }
            else
            {
                return NotFound("No records found");
            }
        }

        [HttpGet("season/{seasonId}/game/{gameId}")]
        public ActionResult<IEnumerable<Attendance>> GetAttendanceBySeasonIdAndGameId(int seasonId, int gameId)
        {
            if (seasonId < 1 || gameId < 1)
            {
                return BadRequest("seasonId and gameId are both required");
            }


            var attendance = _attendanceRepository.GetAttendanceListBySeasonIdAndGameId(seasonId, gameId);

            if (attendance.Count > 0)
            {
                return Ok(attendance);
            }
            else
            {
                return NotFound("No records found");
            }
        }
    }
}
