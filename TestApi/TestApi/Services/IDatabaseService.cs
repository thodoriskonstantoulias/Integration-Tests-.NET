using TestApi.Models;

namespace TestApi.Services
{
    public interface IDatabaseService
    {
        IEnumerable<Game> GetGames();
        void AddGame(Game game);
    }
}
