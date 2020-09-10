using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuestraApi.Entities
{
    public class Serie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public bool Award { get; set; }
        public bool Older18 { get; set; }
    }
}
