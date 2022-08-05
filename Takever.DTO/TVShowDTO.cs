using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Takever.Domain.Entities.TVShow;

namespace Takever.DTO
{
    public class TVShowDTO
    {
        public string Name { get; set; }
        public DateTime ReleaseDates { get; set; }
        public GenreTVShow Genre { get; set; }
    }
}
