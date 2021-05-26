using Kinematik.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kinematik.Database.DbContexts
{
    public class KinematikContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        
        public KinematikContext(DbContextOptions<KinematikContext> options) : base(options)
        {
        }
    }
}