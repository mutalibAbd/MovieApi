using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApi.Aplication.Features.MediatorDesignPattern.Queries.TagQuery;
using MovieApi.Aplication.Features.MediatorDesignPattern.Results.TagResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class GetTagQueryHandler : IRequestHandler<GetTagQuery, List<GetTagQueryResults>>
    {

        private readonly MovieContext context;

        public GetTagQueryHandler(MovieContext context)
        {
            this.context = context;
        }

        public async Task<List<GetTagQueryResults>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            var value = await context.Tags.ToListAsync();

            return value.Select(x => new GetTagQueryResults
            {
                TagId = x.TagId,
                Title = x.Title,
            }).ToList();
        }

        //public async Task<GetTagQueryResults> IRequestHandler<GetTagQuery, List<GetTagQueryResults>.Handle(GetTagQuery request, CancellationToken cancellationToken)
        //{
        //    var value = await context.Tags.ToListAsync();

        //    return value.Select(x => new GetTagQueryResults
        //    {
        //        TagId = x.TagId,
        //        Title = x.Title,
        //    }).ToList();
        //}
    }
}
