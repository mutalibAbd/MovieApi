using MovieApi.Persistence.Context;
using MovieApi.Aplication.Features.CQRSDesignPattern.Queries.MovieQuery;
using MovieApi.Aplication.Features.CQRSDesignPattern.Results.MovieResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandlers
    {
        private readonly MovieContext _context;

        public GetMovieByIdQueryHandlers(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetMovireByIdQueryResults> Handle(GetMovieByIdQuery query)
        {
            var value = await _context.Movies.FindAsync(query.MovieId);
           
            return new GetMovireByIdQueryResults
            {
                MovieId = value.MovieId,
                Title = value.Title,
                CoverimageURL = value.CoverimageURL,
                Rating = value.Rating,
                Description = value.Description,
                Duration = value.Duration,
                ReleaseDate = value.ReleaseDate,
                CreatedYear = value.CreatedYear,
                Status = value.Status,
            };
        }
    }
}
