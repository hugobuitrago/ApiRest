using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takever.Domain.Entities
{
    public class TVShow
    {
        public enum GenreTVShow
        {
            Adventure,
            Romance,
            Thriller,
            Horror
        };

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDates { get; set; }
        public GenreTVShow Genre { get; set; }
    }
}
