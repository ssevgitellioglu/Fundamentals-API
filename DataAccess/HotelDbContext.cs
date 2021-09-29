using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=STELLIOGLU;Database=HotelDB;uid=sa;pwd=Bimser123;");
        }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
