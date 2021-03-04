using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Data
{
   public class DataContext: IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }

       
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }
         
        public DbSet<Category> Categories { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Produsent> Produsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }

}
