using System;

namespace Highscore.Models.Entities
{
    public class Score
    {
        public Score(int id, uint points, DateTime date, string player, int gameId)
        {
            Id = id;
            Points = points;
            Date = date;
            Player = player;
            GameId = gameId;
        }

        public int Id { get; protected set; }
        public uint Points { get; protected set; }
        public DateTime Date { get; protected set; }
        public string Player { get; protected set; }
        public int GameId { get; protected set; }
    }
}
