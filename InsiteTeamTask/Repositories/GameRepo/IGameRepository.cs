using InsiteTeamTask.Models;
using System.Collections.Generic;

namespace InsiteTeamTask.Repositories.GameRepo
{
    public interface IGameRepository
    {
        Game Get(int id);
        List<Game> GetAll();
    }
}
