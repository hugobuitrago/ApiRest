using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Takever.Domain.Entities;
using Takever.DTO;
using static Takever.Domain.Entities.TVShow;

namespace Takever.Service.Interfaces
{
    public interface ITVShowService
    {
        Task<IEnumerable<TVShow>> GetAll();
        Task<IEnumerable<TVShow>> GetTVShowWithFilterByGenre(GenreTVShow genre);
        Task<TVShow> InsertTVShowAsync(TVShowDTO tvShowDTO);
    }
}
