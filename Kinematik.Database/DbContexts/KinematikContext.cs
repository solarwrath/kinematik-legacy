using System.Linq;
using Kinematik.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kinematik.Database.DbContexts
{
    public class KinematikContext: DbContext
    {
        public DbSet<Film> Movies { get; set; }
        
        public KinematikContext(DbContextOptions<KinematikContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            
            modelBuilder.Entity<Film>()
                .HasMany(film => film.Comments)
                .WithOne(comment => comment.Film)
                .HasForeignKey(comment => comment.FilmID);
            modelBuilder.Entity<Film>()
                .HasMany(film => film.Sessions)
                .WithOne(session => session.Film)
                .HasForeignKey(session => session.FilmID);

            modelBuilder.Entity<Session>()
                .HasMany(session => session.Bookings)
                .WithOne(booking => booking.Session)
                .HasForeignKey(booking => booking.SessionID);
            modelBuilder.Entity<Session>()
                .HasOne(session => session.Hall)
                .WithMany(hall => hall.Sessions)
                .HasForeignKey(session => session.HallID);
            
            modelBuilder.Entity<Hall>()
                .HasMany(hall => hall.Seats)
                .WithOne(seat => seat.Hall)
                .HasForeignKey(seat => seat.HallID);
            
            modelBuilder.Entity<Booking>()
                .HasOne(booking => booking.Seat)
                .WithMany(seat => seat.Bookings)
                .HasForeignKey(booking => booking.SeatID);
            modelBuilder.Entity<Booking>()
                .HasOne(booking => booking.User)
                .WithMany(user => user.Bookings)
                .HasForeignKey(booking => booking.UserID);
        }
    }
}