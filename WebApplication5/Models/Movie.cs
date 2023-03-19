using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    
    public class Movie
    {
        [Required(), Key]
        public int Id { get; set; }
        public String Title { get; set; }
        public float Rating { get; set; }
    }

    public class MyDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasKey(e => e.Id); // configure the key
            base.OnModelCreating(modelBuilder);
        }
    }
}