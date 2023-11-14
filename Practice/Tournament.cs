using System.Collections.Generic;
using System;
namespace Practice
{
    class Tournament
    {
        List<IGameStrategy> games = new List<IGameStrategy>();
        public Tournament()
        {
            games.Add(new BeachGame());
            games.Add(new MousetrapGame());
            games.Add(new SeaGame());
            games.Add(new FishingGame());
            games.Add(new PostmanGame());
            games.Add(new SlideGame());
            games.Add(new MyGame());
        }
        public void Start(List<Team> teams)
        {
            foreach (var game in games)
            {
                foreach (var team in teams)
                {
                    team.SetGame(game);
                    team.PlayGame();
                }
            }
        }
    }
}
