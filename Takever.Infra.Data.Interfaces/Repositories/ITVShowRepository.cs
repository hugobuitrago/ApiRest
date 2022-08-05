using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Takever.Domain.Entities;
using static Takever.Domain.Entities.TVShow;

namespace Takever.Infra.Data.Interfaces.Repositories
{
    public interface ITVShowRepository
    {
        Task<IEnumerable<TVShow>> GetAll();
        Task<int> Insert(TVShow tvShow);
        Task<IEnumerable<TVShow>> GetTVShowWithFilterByGenre(GenreTVShow genre);


    }
}
