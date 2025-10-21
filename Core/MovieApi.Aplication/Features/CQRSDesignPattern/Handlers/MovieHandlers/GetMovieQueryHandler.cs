using Microsoft.EntityFrameworkCore;
using MovieApi.Aplication.Features.CQRSDesignPattern.Results.MovieResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
        public readonly MovieContext _context;

        public GetMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetMovieQueryResults>> Handler()
        {
            var movies = await _context.Movies.ToListAsync();
            return movies.Select( x => new GetMovieQueryResults
            {
                MovieId = x.MovieId,
                Title = x.Title,
                CoverimageURL = x.CoverimageURL,
                Rating = x.Rating,
                Description = x.Description,
                Duration = x.Duration,
                ReleaseDate = x.ReleaseDate,
                CreatedYear = x.CreatedYear,
                Status = x.Status,


            }).ToList();

        }
    }
}
