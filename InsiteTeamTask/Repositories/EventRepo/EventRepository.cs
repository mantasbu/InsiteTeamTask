using InsiteTeamTask.MockData;
using InsiteTeamTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace InsiteTeamTask.Repositories.EventRepo
{
    public class EventRepository : IEventRepository
    {
        private readonly IDataService _mockData;

        public EventRepository()
        {
            _mockData = new MockDataService();
        }

        public Event Get(int id)
        {
            return _mockData.Events().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Event> GetAll()
        {
            return _mockData.Events().ToList();
        }
    }
}
