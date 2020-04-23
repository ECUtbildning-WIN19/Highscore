using Highscore.Data;
using Highscore.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO.Compression;
using System.Linq;

namespace Highscore.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class GameController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public GameController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<Game> GetGameById(int id)
        {
            var game = context.Game
                .Include(x => x.Scores)
                .FirstOrDefault(x => x.Id == id);

            if (game == null)
            {
                return NotFound(); // 404
            }

            return game;
        }
    }
}
