using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text;

namespace Simplecade.Data
{
    public class System
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SystemId { get; set; }
        public string Name { get; set; }
        public string ExecutablePath { get; set; }
        public string GamesPath { get; set; }
        public string BoxArtPath { get; set; }
        public string VideoPath { get; set; }
        public string SnapPath { get; set; }
        public string BackgroundPath { get; set; }
        public string ListIconPath { get; set; }
        public string Extensions { get; set; }
        public string Parameters { get; set; }
        public bool IsPCGames { get; set; }

        public List<Game> Games { get; set; }

        public System()
        {
            Games = new List<Game>();
        }

    }
}
