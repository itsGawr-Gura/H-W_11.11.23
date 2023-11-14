using System.Collections.Generic;

namespace Practice
{
    class Team
    {
        public string Country { get; set; }
        public List<string> Players { get; set; }
        private IGameStrategy _game;
        public Team(string country)
        {
            Country = country;
            Players = new List<string>();
        }
        public void SetGame(IGameStrategy game)
        {
            _game = game;
        }
        public void PlayGame()
        {
            _game.Play();
        }
    }
}
