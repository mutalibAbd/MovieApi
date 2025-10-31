using MediatR;
using MovieApi.Aplication.Features.MediatorDesignPattern.Results.TagResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.MediatorDesignPattern.Queries.TagQuery
{
    public class GetTagQuery: IRequest<List<GetTagQueryResults>>
    {
        
    }
}
