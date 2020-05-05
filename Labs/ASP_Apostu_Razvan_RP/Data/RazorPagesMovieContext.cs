using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace ASP_Apostu_Razvan_RP.Data
{
    public class RazorPagesMovieContext : DbContext
    {


        public RazorPagesMovieContext(
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Movie> Movie { get; set; }


    }
}

