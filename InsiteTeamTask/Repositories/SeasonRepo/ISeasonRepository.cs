using InsiteTeamTask.Models;
using System.Collections.Generic;

namespace InsiteTeamTask.Repositories.SeasonRepo
{
    public interface ISeasonRepository
    {
        List<Season> GetSeasonsByEventId(int id);
    }
}
