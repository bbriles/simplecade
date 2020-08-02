using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Simplecade.Data
{
    public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameId { get; set; }
        public int SystemId { get; set; }
        public string Name { get; set; }
        public string Filename { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string Year { get; set; }
        public bool Multiplayer { get; set; }

        public string VideoPath => System != null && System.VideoPath != null ? System.VideoPath + "\\" + Filename + ".mp4" : null;

        public string BoxArtPath =>
            System != null && System.BoxArtPath != null
                ? System.BoxArtPath + "\\" + Filename + ".png"
                : null;

        public string ListIconPath =>
            System != null && System.ListIconPath != null
                ? System.ListIconPath + "\\" + Filename + ".png"
                : null;

        public string FilePath =>
            System != null && System.GamesPath != null
                ? System.GamesPath + "\\" + Filename + "." + System.Extensions
                : null;

        [ForeignKey("SystemId")]
        public System System { get; set; }

    }
}
