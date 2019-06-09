using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Segundodotnet.Models
{
    public class ArtistaModel
    {
        [Key]
        public int ArtistaId { get; set; }
        public string NomeArtista { get; set; }
        public string NomeDisco { get; set; }
        public int AnoDisco { get; set; }
    }
}