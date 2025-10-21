using MovieApi.Aplication.Features.CQRSDesignPattern.Results.CatagoryResults;
using MovieApi.Aplication.Features.CQRSDesignPattern.Queries.CatagoryQueries;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.CatagoryHandlers
{
    public class GetCatagoryByIdQueryHandler
    {
        private readonly MovieContext _context;

        public GetCatagoryByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetCatagoryByIdQueryResults> Handle(GetCatagoryByIdQuery query)
        {
            var value = await _context.Categories.FindAsync(query.CatagoryId);
            return new GetCatagoryByIdQueryResults
            {
               CatagoryId = value.CatagoryId,
                CatagoryName = value.CatagoryName

            };
        }
    }
}
