using System;
using System.Collections.Generic;
using System.Text;
using Simplecade.Data;
using Simplecade.Data.Services;

namespace Simplecade.ViewModel
{
    public class MainViewModel
    {
        private readonly IGameService _gameService = new GameService();

        public List<Game> Games { get; set; }

        public MainViewModel()
        {
            Games = _gameService.GetGames();
        }

    }
}
