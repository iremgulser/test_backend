using System.Collections.Generic;
using test_backend.Models;
using Microsoft.EntityFrameworkCore;


namespace test_backend.Controllers
{
    public class ParcelDbContext : DbContext
    {
        public ParcelDbContext(DbContextOptions<ParcelDbContext> options) : base(options)
        {

        }
        public DbSet<Parcel> Parcels { get; set; }

    }
}