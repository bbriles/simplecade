using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Simplecade.Data;
using Simplecade.Data.Services;

namespace Simplecade.ViewModel
{
    public class MainViewModel
    {
        private readonly IGameService _gameService = new GameService();

        public bool IsPlaying { get; set; }

        public List<Game> Games { get; set; }

        public MainViewModel()
        {
            IsPlaying = false;
            Games = _gameService.GetGames();
        }

        public void StartGame(Game game)
        {
            Clipboard.SetText(game.System.ExecutablePath + " " + "\"" + game.FilePath + "\" " + game.System.Parameters);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = game.System.ExecutablePath,
                Arguments = "\""+game.FilePath+"\" " + game.System.Parameters
            };
            process.EnableRaisingEvents = true;
            process.StartInfo = startInfo;
            process.Exited += (sender, e) => { IsPlaying = false; };
            IsPlaying = true;
            process.Start();
        }
    }
}
