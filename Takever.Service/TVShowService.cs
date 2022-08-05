using System.Collections.Generic;
using System.Threading.Tasks;
using Takever.Domain.Entities;
using Takever.DTO;
using Takever.Infra.Data.Interfaces.Repositories;
using Takever.Service.Interfaces;
using static Takever.Domain.Entities.TVShow;

namespace Takever.Service
{
    public class TVShowService : ITVShowService
    {
        readonly ITVShowRepository _tvShowRepository;

        public TVShowService(ITVShowRepository tvShowRepository)
        {
            _tvShowRepository = tvShowRepository;
        }

        public async Task<IEnumerable<TVShow>> GetAll()
        {
            return await _tvShowRepository.GetAll();
        }

        public async Task<IEnumerable<TVShow>> GetTVShowWithFilterByGenre(GenreTVShow genre)
        {
            return await _tvShowRepository.GetTVShowWithFilterByGenre(genre);
        }

        

        public async Task<TVShow> InsertTVShowAsync(TVShowDTO tvShowDTO)
        {
            TVShow tvShow = new TVShow();
            tvShow.Genre = tvShowDTO.Genre;
            tvShow.Name = tvShowDTO.Name;
            tvShow.ReleaseDates = tvShowDTO.ReleaseDates;
            
            await _tvShowRepository.Insert(tvShow);
            return tvShow;
        }
    }
}
