using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.MediatorDesignPattern.Commands.TagCommands
{
    public class CreateTagCommand: IRequest
    {
        public string Title { get; set; }
    }
}
