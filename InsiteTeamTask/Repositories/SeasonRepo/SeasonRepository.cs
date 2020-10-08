using InsiteTeamTask.MockData;
using InsiteTeamTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace InsiteTeamTask.Repositories.SeasonRepo
{
    public class SeasonRepository : ISeasonRepository
    {
        private readonly IDataService _mockData;

        public SeasonRepository()
        {
            _mockData = new MockDataService();
        }

        public List<Season> GetSeasonsByEventId(int eventId)
        {
            return _mockData.Seasons().Where(x => x.Id == eventId).ToList();
        }
    }
}
