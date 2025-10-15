using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Commands.MovieCommands
{
    public class RemoveMovieCommands
    {
        public int MovieId { get; set; }
    }
}
