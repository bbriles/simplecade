using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Simplecade.Data.Services
{
    public class GameService : IGameService
    {
        public List<Game> GetGames()
        {
            using (var dbContext = new SimplecadeContext())
            {
                return dbContext.Games.Include(game => game.System).ToList();
            }
        }
    }
}
