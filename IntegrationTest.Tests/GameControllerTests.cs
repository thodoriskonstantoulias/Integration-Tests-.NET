using FluentAssertions;
using System.Net.Http.Json;
using TestApi.Models;

namespace IntegrationTest.Tests
{
    public class GameControllerTests
    {
        [Fact]
        public async Task GameRequest_AddGameToDatabase()
        {
            var application = new TestApplicationFactory();
            var client = application.CreateClient();

            var game = new Game
            {
                Round = 1,
                Player1 = "test1",
                Player2 = "test2"
            };

            var response = await client.PostAsJsonAsync("/api/game/CreateGame", game);
            
            response.EnsureSuccessStatusCode();

            var gameResponse = await response.Content.ReadFromJsonAsync<Game>();

            gameResponse?.Round.Should().BePositive();
            gameResponse?.Player1?.Should().Contain("test1");
        }
    }
}