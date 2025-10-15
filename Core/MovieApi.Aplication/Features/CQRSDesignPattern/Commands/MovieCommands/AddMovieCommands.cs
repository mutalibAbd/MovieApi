using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Commands.MovieCommands
{
    public class AddMovieCommands
    {
     
        public string Title { get; set; }

        public string CoverimageURL { get; set; }
        public decimal Rating { get; set; }

        public String Description { get; set; }

        public int Duration { get; set; }

        public DateTime ReleaseDate { get; set; }

        public String CreatedYear { get; set; }

        public bool Status { get; set; }
    }
}
