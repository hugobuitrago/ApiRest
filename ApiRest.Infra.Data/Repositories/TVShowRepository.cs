using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Takever.Domain.Entities;
using Takever.Infra.Data.Context;
using Takever.Infra.Data.Interfaces.Repositories;
using static Takever.Domain.Entities.TVShow;

namespace Takever.Infra.Data.Repositories
{
    public class TVShowRepository : ITVShowRepository
    {
        readonly ApiRest_Context _context;
        public TVShowRepository(ApiRest_Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TVShow>> GetAll()
        {
            return await _context.TVShow.ToListAsync();
        }

        public async Task<int> Insert(TVShow caminhao)
        {
            _context.TVShow.Add(caminhao);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TVShow>> GetTVShowWithFilterByGenre(GenreTVShow genre)
        {
            return await _context.TVShow.Where(t => t.Genre == genre).OrderByDescending(t => t.ReleaseDates).ToListAsync();
        }
    }
}
