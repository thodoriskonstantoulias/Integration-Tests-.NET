using TestApi.Models;

namespace TestApi.Services
{
    public class InMemoryDatabaseService : IDatabaseService
    {
        private List<Game> _games;
        public InMemoryDatabaseService()
        {
            _games = new List<Game>();
        }

        public IEnumerable<Game> GetGames()
        {
            return _games;
        }

        public void AddGame(Game game)
        {
            _games.Add(game);
        }
    }
}
