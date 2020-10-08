using InsiteTeamTask.Models;
using System.Collections.Generic;

namespace InsiteTeamTask.Repositories.AttendanceRepo
{
    public interface IAttendanceRepository
    {
        List<Attendance> GetAttendanceListByProductId(string productId);
        List<Attendance> GetAttendanceListBySeasonId(int seasonId);
        List<Attendance> GetAttendanceListByGameId(int gameId);
        List<Attendance> GetAttendanceListBySeasonIdAndGameId(int seasonId, int gameId);
    }
}
