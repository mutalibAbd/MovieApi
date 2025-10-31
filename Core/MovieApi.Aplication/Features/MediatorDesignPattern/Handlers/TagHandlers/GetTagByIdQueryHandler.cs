using MediatR;
using MovieApi.Aplication.Features.MediatorDesignPattern.Queries.TagQuery;
using MovieApi.Aplication.Features.MediatorDesignPattern.Results.CastResults;
using MovieApi.Aplication.Features.MediatorDesignPattern.Results.TagResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResults>
    {
        public readonly MovieContext context;


        public GetTagByIdQueryHandler(MovieContext context)
        {
            this.context = context;
        }

        public async Task<GetTagByIdQueryResults> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await context.Tags.FindAsync(request.TagId);
            return (new GetTagByIdQueryResults
            {
                TagId = value.TagId,
                Title = value.Title,
            });
        }
    }
}
