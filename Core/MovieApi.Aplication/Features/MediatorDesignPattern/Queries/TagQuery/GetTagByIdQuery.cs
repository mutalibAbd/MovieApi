using MediatR;
using MovieApi.Aplication.Features.MediatorDesignPattern.Results.CastResults;
using MovieApi.Aplication.Features.MediatorDesignPattern.Results.TagResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.MediatorDesignPattern.Queries.TagQuery
{
    public class GetTagByIdQuery: IRequest<GetTagByIdQueryResults>
    {
        public int TagId { get; set; }

        public GetTagByIdQuery(int tagId)
        {
            TagId = tagId;
        }
    }
}
