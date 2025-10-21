using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Domain.Entites
{
    public class Movie
    {
        public int MovieId { get; set; }
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
