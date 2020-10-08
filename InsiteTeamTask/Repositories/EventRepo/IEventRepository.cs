using InsiteTeamTask.Models;
using System.Collections.Generic;

namespace InsiteTeamTask.Repositories.EventRepo
{
    public interface IEventRepository
    {
        Event Get(int id);
        List<Event> GetAll();
    }
}
