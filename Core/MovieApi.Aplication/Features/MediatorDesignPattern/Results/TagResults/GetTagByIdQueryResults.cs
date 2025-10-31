using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.MediatorDesignPattern.Results.TagResults
{
    public class GetTagByIdQueryResults
    {
        public int TagId { get; set; }
        public string Title { get; set; }
    }
}
