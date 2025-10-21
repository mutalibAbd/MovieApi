﻿using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Persistence.Context
{
    public class MovieContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost;Initial Catalog=ApiMovieDb;Integrated Security=True;TrustServerCertificate=True");
        }


        public DbSet<Catagory> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Cast> Casts { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public DbSet<Tag> Tags { get; set; }

        
    }
}