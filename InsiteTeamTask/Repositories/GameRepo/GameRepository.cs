using InsiteTeamTask.MockData;
using InsiteTeamTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace InsiteTeamTask.Repositories.GameRepo
{
    public class GameRepository : IGameRepository
    {
        private readonly IDataService _mockData;

        public GameRepository()
        {
            _mockData = new MockDataService();
        }

        public Game Get(int id)
        {
            return _mockData.Games().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Game> GetAll()
        {
            return _mockData.Games().ToList();
        }
    }
}
