﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Domain.Entites
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewerComment { get; set; }
        public int UserRating { get; set; }
        public DateTime ReviewDate { get; set; }

        public bool Status { get; set; }
    }
}
