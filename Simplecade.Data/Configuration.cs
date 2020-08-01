using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Simplecade.Data
{
    public class Configuration
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConfigurationId { get; set; }

        public string BoxArtPath { get; set; }
        public string VideoPath { get; set; }
        public string SnapPath { get; set; }
        public string BackgroundPath { get; set; }
    }
}
