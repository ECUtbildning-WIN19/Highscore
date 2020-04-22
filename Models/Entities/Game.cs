using System;

namespace Highscore.Models.Entities
{
    public class Game
    {
        public Game(int id, string title, string description, Uri imageUrl)
        {
            Id = id;
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
        }

        public int Id { get; protected set; }

        public string Title { get; protected set; }

        public string Description { get; protected set; }

        public Uri ImageUrl { get; protected set; }
    }
}
