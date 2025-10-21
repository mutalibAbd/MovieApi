using Microsoft.EntityFrameworkCore;
using MovieApi.Aplication.Features.CQRSDesignPattern.Results.CatagoryResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.CatagoryHandlers
{
    
    public class GetCatagoryQueryHandler
    {
        public readonly MovieContext _context;

        public GetCatagoryQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetCatagoryQueryResults>> Handle()
        {
            var catagories = await _context.Categories.ToListAsync();
            return catagories.Select(c => new GetCatagoryQueryResults
            {
                CatagoryId = c.CatagoryId,
                CatagoryName= c.CatagoryName
            }).ToList();
        }
    }
}
